﻿using AutoMapper;
using MercadoLibre.Backend.Application;
using MercadoLibre.Backend.Application.Mappers;
using MercadoLibre.Backend.Application.Services;
using MercadoLibre.Backend.Application.Services.Interfaces;
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

            services.Configure<ApplicationSettings>(Configuration.GetSection("AppSettings"));

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