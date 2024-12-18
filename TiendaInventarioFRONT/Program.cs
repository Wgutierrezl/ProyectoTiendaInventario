using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TiendaInventarioFRONT;
using TiendaInventarioFRONT.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7263/") });
builder.Services.AddScoped<IServiciosProveedores, ServiciosProveedores>();
builder.Services.AddScoped<IServiciosCategorias, ServiciosCategorias>();
builder.Services.AddScoped<IServiciosProductos, ServiciosProductos>();
builder.Services.AddScoped<IServiciosOrdenes, ServiciosOrdenes>();
builder.Services.AddScoped<IServiciosDetalleOrden, ServiciosDetalleOrden>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
