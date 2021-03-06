using Matdata.API.Services.Agenda;
using Matdata.API.Services.Comment;
using Matdata.API.Services.Gallery;
using Matdata.API.Services.Message;
using Matdata.API.Services.Posts;
using MatData.Data;
using MatData.Services.Category;
using MatData.Services.DynamicProfile;
using MatData.Services.Indicator;
using MatData.Services.Municipe;
using MatData.Services.NeighborhoodVillage;
using MatData.Services.Province;
using MatData.Services.Token;
using MatData.Services.UrbanDistrictCommune;
using MatData.Services.User;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatData
{
    public class Startup
    {
        private readonly IWebHostEnvironment _environment;

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        { 
            _environment = environment;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            services.AddDirectoryBrowser();

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
                options.UseNpgsql(Configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            });

            var key = Encoding.ASCII.GetBytes(Configuration.GetValue<string>("JsonWebToken:Secret"));

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            services.AddTransient<IProvinceService, ProvinceService>();
            services.AddTransient<IMunicipeService, MunicipeService>();
            services.AddTransient<IUrbanDistrictCommuneService, UrbanDistrictCommuneService>();
            services.AddTransient<INeighborhoodVillageService, NeighborhoodVillageService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IIndicatorService, IndicatorService>();
            services.AddTransient<ITokenService, TokenService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IDynamicProfileService, DynamicProfileService>();
            services.AddTransient<IHistoryDataService, HistoryDataService>();
            services.AddTransient<IAgendaService, AgendaService>();
            services.AddTransient<ICommentService, CommentService>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IGalleryService, GalleryService>();

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

            app.UseCors(builder =>
                builder
                    .WithOrigins("http://localhost:3000", "http://localhost:3001", "http://localhost:3002")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                );

            //app.UseHttpsRedirection();

            app.UseStaticFiles();

            var fileProvider = new PhysicalFileProvider(
                Path.Combine(_environment.WebRootPath, "Repository"));

            var requestPath = "/Repository";

            // Enable displaying brownswer links
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = fileProvider,
                RequestPath = requestPath
            });

            app.UseDirectoryBrowser(new DirectoryBrowserOptions
            {
                FileProvider = fileProvider,
                RequestPath = requestPath
            });

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
