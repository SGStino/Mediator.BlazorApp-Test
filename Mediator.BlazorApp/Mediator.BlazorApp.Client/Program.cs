using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.Services.AddMediator(o =>
{
    o.Namespace = "Client";
    o.ServiceLifetime = ServiceLifetime.Scoped;
});
await builder.Build().RunAsync();
