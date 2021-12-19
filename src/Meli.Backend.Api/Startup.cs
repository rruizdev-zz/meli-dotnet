﻿using System.Diagnostics.CodeAnalysis;
using AutoMapper;
using Meli.Backend.Application;
using Meli.Backend.Application.Mappers;
using Meli.Backend.Application.Services;
using Meli.Backend.Application.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSwag;

namespace Meli.Backend.Api
{
    [ExcludeFromCodeCoverage]
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

            services.AddCors(options =>
            {
                options.AddPolicy("_corsOrigins", builder =>
                {
                    builder.WithOrigins("http://localhost:1810");
                });
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Version = "v1";
                    document.Info.Title = "meli-dotnet";
                    document.Info.Description = "ASP.NET Core Web API works with external API";
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

            app.UseCors("_corsOrigins");

            app.UseMvc();

            app.UseOpenApi();

            app.UseSwaggerUi3();
        }
    }
}
