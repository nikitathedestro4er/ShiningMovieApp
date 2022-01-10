using AuthenticationApi.Data;
using AuthenticationApi.Models;
using AuthenticationApi.Services.AuthenticationService;
using AuthenticationApi.Services.EmailService;
using AuthenticationApi.Services.GrpcAuthenticationService;
using AuthenticationApi.Services.TokenService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace AuthenticationApi
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
            
            services.AddRabbitMQ(Configuration);
            
            services.AddGrpc();
            
            services.AddControllers();
            
            services.AddDbContextPool<IdentityContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:IDentityConnection"]);
            });
            
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<IdentityContext>().AddDefaultTokenProviders();

            services.Configure<TokenSettings>(Configuration.GetSection(nameof(TokenSettings)));
            
            

            services.AddScoped<IAuthenticationService, AuthenticationService>();

            services.AddScoped<ITokenService, TokenService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            

            app.UseHttpsRedirection();
            
            app.UseStaticFiles();

            app.UseCors(b => b.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod().WithExposedHeaders("X-Pagination"));

            app.UseRouting();

            
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                
                endpoints.MapGrpcService<GrpcAuthenticationService>().RequireHost($"*:6000");
                
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client.");
                });
                
                
            });
            
            IdentitySeedData.CreateAdminAccount(app.ApplicationServices, Configuration);
        }
    }
}