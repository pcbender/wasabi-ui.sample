using EmbeddedBlazorContent;
using MatBlazor;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WasabiUI.Forms.Core;
using Xamarin.Forms;

namespace TipCalc.Forms.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddWasabiPlatformServices(config =>
            {
                config.UseFluidLayout = false;
                config.IgnoreInlineStyles = false;
                config.ScalingFactor = 1d;
                config.ScaledScreenSize = new Size(1024,768);
                config.PixelScreenSize = new Size(800,600);
                config.CssUnit = CssUnit.Px;
                config.SizeFactor = 1d;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseEmbeddedBlazorContent(typeof(BaseMatComponent).Assembly);
            app.UseEmbeddedBlazorContent(typeof(TipCalc.Forms.Web.Pages.MainPage).Assembly);

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            app.UseWasabiPlatform();
        }
    }
}
