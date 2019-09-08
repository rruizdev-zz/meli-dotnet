# meli-dotnet
ASP.NET Core Web API demo, works with MercadoLibre API. Their main function are search and retrieve articles in SPA.

This solution has four layers: 
* WebApi (controllers, viewable in Swagger)
* Application (with business logic, where data get from [MercadoLibre public API](https://developers.mercadolibre.com.ar/es_ar/items-y-busquedas), and mappers)
* Domain (only entities)
* Web (only frontend content)

## Technologies
* .NET Core 2.2 ([Download](https://dotnet.microsoft.com/download)). Compatibility with Windows, Linux and Mac.
* Swagger ([NSwag](https://github.com/RicoSuter/NSwag)).
* NUnit ([Console](https://nunit.org/download/)).
* Node.js ([Download](https://nodejs.org/es/download/)) & TypeScript.
* Angular ([Docs](https://angular.io/)).

## How to run it
After clone this repository, navigate into directory and put these commands to build backend:

    cd MercadoLibre.Backend.WebApi
    dotnet restore
    dotnet build
    dotnet run

And, to run frontend, you must input these commands:

    cd MercadoLibre.Backend.Web
    dotnet restore
    dotnet build
    dotnet run

> Assumming you've installed .NET Core SDK, Node.js and Angular dependencies. Please, download and install it if you didn't make it yet.

### Voilá! 
This solution running local, in two ports:
- Backend: `http://localhost:1811`
- Frontend: `http://localhost:1810`

If you want to view methods and entities, you can see Swagger in `http://localhost:1811/swagger`.
