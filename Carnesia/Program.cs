using Carnesia;
using Carnesia.Application.CMS.Services;
using Carnesia.Application.Vendor.Services;
using Carnesia.Application.WMS.PO.Services;
using Carnesia.Application.WMS.Store.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddMudServices();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://carnesiaapi.bespokeit.io/api/") });
builder.Services.AddScoped<IPurchaseOrder, PurchaseOrderService>();
builder.Services.AddScoped<IVendor, VendorServices>();
builder.Services.AddScoped<IStore, StoreService>();
builder.Services.AddScoped<IProduct, ProductService>();

await builder.Build().RunAsync();
