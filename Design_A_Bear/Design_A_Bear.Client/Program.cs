using Design_A_Bear.Client;
using Design_A_Bear.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();
builder.Services.AddScoped<IItemService,ClientItemService>();
builder.Services.AddScoped<IImageService,ImageService>();
builder.Services.AddScoped<IFavoriteService,ClientFavoriteService>();
builder.Services.AddScoped<IBasketService, ClientBasketService>();

await builder.Build().RunAsync();
