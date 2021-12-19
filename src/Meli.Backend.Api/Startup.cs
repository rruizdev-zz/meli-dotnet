using System.Diagnostics.CodeAnalysis;
using AutoMapper;
using MediatR;
using Meli.Backend.Application;
using Meli.Backend.Application.Mappers;
using Meli.Backend.Application.Services;
using Meli.Backend.Application.Services.Interfaces;

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

            services.AddMediatR(typeof(Startup));

            services.AddControllers();

            services.AddSwaggerGen();
            //{
            //    config.

            //    config.SchemaGeneratorOptions = document =>
            //    {
            //        document.Info.Version = "v1";
            //        document.Info.Title = "meli-dotnet";
            //        document.Info.Description = "ASP.NET Core Web API works with external API";
            //        document.Info.TermsOfService = "None";
            //        document.Info.Contact = new OpenApiContact
            //        {
            //            Name = "Roberto Ruiz",
            //            Url = "https://linktr.ee/rruizdev"
            //        };
            //    };
            //});
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("_corsOrigins");

            app.UseSwagger();

            app.UseSwaggerUI();
        }
    }
}
