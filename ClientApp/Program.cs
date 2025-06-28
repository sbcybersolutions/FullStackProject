// This file is part of the ClientApp project.
// It sets up the Blazor WebAssembly application, registers components, and configures services.

using System.Net.Http;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ClientApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register root components
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<ProductService>();

// Configure HttpClient with the base address from the environment
builder.Services.AddScoped<HttpClient>(sp =>
    new HttpClient { BaseAddress = new Uri("http://localhost:5093") });

// Build and run the application
await builder.Build().RunAsync();