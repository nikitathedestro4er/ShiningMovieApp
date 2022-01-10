using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Shining.LoggerService;
using NLog;
using Shining.Extensions;
using System.IO;
using Services.Abstractions;
using Domain.Services.Repositories;
using Infrastructure.Repositories;
using Infrastructure.DbContexts;
using Microsoft.OpenApi.Models;
using Services.Services;
using Shining.Services.Binders;
using Shining.Services.FileServices;
using FluentValidation.AspNetCore;
using FluentValidation;
using DTOs.Movie;
using Services.Validators;
using DTOs.Actor;
using DTOs.Director;
using Shining.Services.AuthenticationService;
using Shining.Services.EmailService;

namespace Shining
{
    public class Startup
    {
        private IWebHostEnvironment _env;

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            _env = env;
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }
        

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddRabbitMQ(Configuration);
            
            services.AddControllers(o => {
                o.ModelBinderProviders.Insert(0, new ModelWithFileBinderProvider());
            }).AddFluentValidation();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

            services.AddScoped<IServiceManager, ServiceManager>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddSingleton<ILoggerManager, LoggerManager>();

            services.AddDbContext<DataContext>(options => 
            {
                options.UseSqlServer(
                    Configuration["ConnectionStrings:MovieConnection"]
                );
            });

            
            

            services.AddAuthentication("Token")
                .AddScheme<TokenAuthSchemeOptions, TokenAuthHandler>("Token",null);

            services.AddAuthorization();
            
            services.AddSingleton<IFileService, FileService>();

            services.AddCors();


            services.AddTransient<IValidator<MovieForCreationDTO>, MovieForCreationDTOValidator>();

            services.AddTransient<IValidator<MovieForUpdateDTO>, MovieForUpdateDTOValidator>();

            services.AddTransient<IValidator<ActorForCreationDTO>, ActorForCreationDTOValidator>();

            services.AddTransient<IValidator<ActorForUpdateDTO>, ActorForUpdateDTOValidator>();

            services.AddTransient<IValidator<DirectorForCreationDTO>, DirectorForCreationDTOValidator>();

            services.AddTransient<IValidator<DirectorForUpdateDTO>, DirectorForUpdateDTOValidator>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ILoggerManager logger)
        {
            if (_env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();

                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web v1"));
            }

            app.ConfigureExceptionHandler(logger);

            app.UseDefaultFiles();

            app.UseStaticFiles();

            app.UseCors(b => b.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod().WithExposedHeaders("X-Pagination"));

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
