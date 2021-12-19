using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore;

namespace Meli.Backend.Api
{
    [ExcludeFromCodeCoverage]
    public class Program
    {
        public static void Main(string[] args) => 
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build()
                .Run();
    }
}
