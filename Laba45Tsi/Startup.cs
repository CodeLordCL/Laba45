using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba45Tsi.Managers.filmManager;
using Laba45Tsi.Managers.genreManager;
using Laba45Tsi.Managers.producerManager;
using Laba45Tsi.Storage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Laba45Tsi
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath).AddJsonFile("dbSettings.json").Build();
        }

        //public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<dbContext>(options => options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            services.AddRazorPages();
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddTransient<iFilmManager, filmManager>();
            services.AddTransient<iGenreManager, genreManager>();
            services.AddTransient<iProducerManager, producerManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "default",
                  template: "{controller=genre}/{action=showGenre}");
            });
        }
    }
}
