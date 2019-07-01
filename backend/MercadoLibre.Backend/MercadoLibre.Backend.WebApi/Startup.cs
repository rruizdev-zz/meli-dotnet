using AutoMapper;
using MercadoLibre.Backend.Domain.Services;
using MercadoLibre.Backend.Domain.Services.Interfaces;
using MercadoLibre.Backend.WebApi.Mappers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MercadoLibre.Backend.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient<IItemsService, ItemsService>();

            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.AddProfile(new ItemMapper());
            }).CreateMapper());

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerDocument();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseOpenApi();

            app.UseSwaggerUi3();
        }
    }
}
