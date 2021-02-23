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
            // STANDALONE: builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // Our requests will go through the API service
            // STANDALONE: builder.Services.AddScoped<IApiService, StandaloneApiService>();
            /* HOSTED */ builder.Services.AddScoped<IPrerenderCache, PrerenderCache>();
            /* HOSTED */ builder.Services.AddScoped<IApiService, ApiService>();

            await builder.Build().RunAsync();
        }
    }
}
