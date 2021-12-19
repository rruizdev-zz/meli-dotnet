using AutoMapper;
using MediatR;
using Meli.Backend.Api;
using Meli.Backend.Application.Mappers;
using Meli.Backend.Application.Services;
using Meli.Backend.Application.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<IItemsService, ItemsService>();

builder.Services.AddSingleton(new MapperConfiguration(config =>
{
    config.AddProfile(new ItemMapper());
}).CreateMapper());

builder.Services.AddCors(options =>
{
    options.AddPolicy("_corsOrigins", builder =>
    {
        builder.WithOrigins("http://localhost:1810");
    });
});

builder.Services.AddMediatR(typeof(Program));

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

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

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseCors("_corsOrigins");

app.UseSwagger();

app.UseSwaggerUI();

app.Run();
