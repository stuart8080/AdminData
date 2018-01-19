using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AdminData.DataAccess;
// using AdminData.Services;

namespace AdminData
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            this.config = builder.Build();
        }

        public IConfigurationRoot config{ get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(this.config);

            services.AddDbContext<ContextExelOperations>(ServiceLifetime.Scoped);
            services.AddDbContext<ContextInflow>(ServiceLifetime.Scoped);
            services.AddDbContext<ContextWebsite>(ServiceLifetime.Scoped);

            services.AddScoped<ISuppliersRepository,SuppliersRepository>();
       
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            });

            // Add framework services.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            // loggerFactory.AddConsole(this.config.GetSection("Logging"));
            // loggerFactory.AddDebug();
            
            // https://stackoverflow.com/questions/40148660/how-to-get-a-console-output-in-asp-net-core-with-iis-express
            // loggerFactory.MinimumLevel = LogLevel.Debug;
            loggerFactory.AddDebug( LogLevel.Debug );
            var logger = loggerFactory.CreateLogger("Startup");
            logger.LogWarning("Logger configured!");
           

            app.UseCors("AllowAll");

            app.UseMvc(config => 
            {
                // config.MapRoute("MainApiRoute", "api/{controller}/{action}");
            });

        }
    }
}
