using MatData.Data;
using MatData.Services.Category;
using MatData.Services.Indicator;
using MatData.Services.Municipe;
using MatData.Services.NeighborhoodVillage;
using MatData.Services.Province;
using MatData.Services.UrbanDistrictCommune;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatData
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

            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MatData", Version = "v1" });
            });
            services.AddDbContext<AppDbContext>(options =>
            {
                options.EnableDetailedErrors();
                options.UseNpgsql(Configuration.GetConnectionString("sigibm.dev"));
            });
            
            services.AddTransient<IProvinceService, ProvinceService>();
            services.AddTransient<IMunicipeService, MunicipeService>();
            services.AddTransient<IUrbanDistrictCommuneService, UrbanDistrictCommuneService>();
            services.AddTransient<INeighborhoodVillageService, NeighborhoodVillageService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IIndicatorService, IndicatorService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MatData v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
