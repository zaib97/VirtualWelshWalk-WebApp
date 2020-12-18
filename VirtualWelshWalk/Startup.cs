using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using VirtualWelshWalk.Areas.Identity;
using VirtualWelshWalk.DataAccess.CRUD;
using VirtualWelshWalk.DataAccess.Data;
using VirtualWelshWalk.DataAccess.Models;
using VirtualWelshWalk.DataAccess.Services;

namespace VirtualWelshWalk
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.User.RequireUniqueEmail = true;
            })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            //services.AddSingleton<WeatherForecastService>();

            services.AddSingleton<IEmailSender, EmailSender>();

            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IVirtualWalkRepository, VirtualWalkRepository>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IVirtualWalkService, VirtualWalkService>();

            services.AddControllers();
            services.AddLocalization(options => options.ResourcesPath = "Resources");
        }

        private RequestLocalizationOptions GetLocalizationOptions()
        {
            var cultures = Configuration.GetSection("Cultures")
                .GetChildren().ToDictionary(X => X.Key, x => x.Value);

            var supportedCultures = cultures.Keys.ToArray();

            // Add the supported cultures from app settings 
            var localizationOptions = new RequestLocalizationOptions()
                .AddSupportedCultures(supportedCultures)
                .AddSupportedUICultures(supportedCultures);

            return localizationOptions;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
