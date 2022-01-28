using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blaze;
using Microsoft.AspNetCore.Components.Authorization;
using Blaze.Services;
using Blaze.Models;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");

builder.RootComponents.Add<HeadOutlet>("head::after");


// Add services

builder.Services.AddOptions();

builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<AuthenticationStateProvider, AuthenticatedUserStateProvider>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register states
builder.Services.AddSingleton<AppStateContainer>();
builder.Services.AddSingleton<UserState>();

await builder.Build().RunAsync();
