using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TiendaFrontInventario.Services;
using TiendaFrontInventario;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7263/") });
builder.Services.AddScoped<IServiciosProveedores, ServiciosProveedores>();
builder.Services.AddScoped<IServiciosCategorias, ServiciosCategorias>();
builder.Services.AddScoped<IServiciosProductos, ServiciosProductos>();
builder.Services.AddScoped<IServiciosOrdenes, ServiciosOrdenes>();
builder.Services.AddScoped<IServiciosDetalleOrden, ServiciosDetalleOrden>();

await builder.Build().RunAsync();
