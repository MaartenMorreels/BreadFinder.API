using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using BreadFinder.API.DAL;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Swagger;
using BreadFinder.API.DAL.Repos;
using BreadFinder.API.BLL;

namespace BreadFinder.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddCors(option => option.AddPolicy("myPolicy", p =>
            {
                p.AllowAnyHeader();
                p.AllowAnyMethod();
                p.AllowAnyOrigin();
            }
            ));

            services.AddDbContext<BreadFinderContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("BreadFinderDB")));

            services.AddScoped<IAutomaatRepository, AutomaatRepository>();
            services.AddScoped<IEigenaarRepository, EigenaarRepository>();
            services.AddScoped<IPlaatsRepository, PlaatsRepository>();
            services.AddScoped<IAutomatenListItemDTO, AutomatenListItemDTO>();
            services.AddScoped<IAutomaatDTO, AutomaatDTO>();
            services.AddScoped<IEigenaarDTO, EigenaarDTO>();
            services.AddScoped<IPlaatsDTO, PlaatsDTO>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
            IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("myPolicy");

            app.UseSwagger();
            app.UseSwaggerUI(options =>
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1")
            );

            app.UseMvc();
        }
    }
}
