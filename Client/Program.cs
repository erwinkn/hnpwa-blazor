using System;
using System.Net.Http;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using HnpwaBlazor.Shared.Services;

namespace HnpwaBlazor.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            string environment = builder.HostEnvironment.Environment;
            if(environment == "Standalone")
            {
                builder.RootComponents.Add<App>("#app");
            }

            // Our requests will go through the API service
            if(environment == "Standalone")
            {
                builder.Services.AddScoped<StandaloneApiService>();
            }
            else
            {
                builder.Services.AddScoped<IPrerenderCache, PrerenderCache>();
                builder.Services.AddScoped<ApiService>();
            }
            
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
