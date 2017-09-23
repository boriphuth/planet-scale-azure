using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Online.Store.Azure.Services;
using Online.Store.DocumentDB;
using Online.Store.Mappings;
using Online.Store.Storage;
using Online.Store.RedisCache;

namespace Online_Store
{
    public class Startup
    {
        private const string RedisCacheConnStringFormat = "{0},abortConnect=false,ssl=true,password={1}";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Make Configuration injectable
            services.AddSingleton<IConfiguration>(Configuration);

            // Configure Cache
            services.AddDistributedRedisCache(option =>
            {
                option.Configuration = string.Format(RedisCacheConnStringFormat,
                            Configuration["RedisCache:Endpoint"],
                            Configuration["RedisCache:Key"]);
                option.InstanceName = "master";
            });

            services.AddScoped<IDocumentDBRepository<DocumentDBStoreRepository>, DocumentDBStoreRepository>();
            services.AddScoped<IRedisCacheRepository, RedisCacheReposistory>();
            services.AddScoped<IStoreService, StoreService>();

            services.AddMvc();

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            AutoMapperConfiguration.Configure();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });

            DocumentDBInitializer.Initialize(Configuration);
        }
    }
}
