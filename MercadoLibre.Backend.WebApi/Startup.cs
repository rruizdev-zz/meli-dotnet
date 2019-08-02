using AutoMapper;
using MercadoLibre.Backend.Application;
using MercadoLibre.Backend.Application.Mappers;
using MercadoLibre.Backend.Application.Services;
using MercadoLibre.Backend.Application.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSwag;

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

            services.Configure<ApplicationSettings>(Configuration.GetSection("AppSettings"));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Version = "v1";
                    document.Info.Title = "meli-dotnet";
                    document.Info.Description = "ASP.NET Core Web API works with MercadoLibre API";
                    document.Info.TermsOfService = "None";
                    document.Info.Contact = new OpenApiContact
                    {
                        Name = "Roberto Ruiz",
                        Email = "robertoruiz@live.com.ar",
                        Url = "https://robrui.github.io"
                    };
                };
            });
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
