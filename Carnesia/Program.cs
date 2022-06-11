using Carnesia;
using Carnesia.Application.Common.Service.Base64;
using Carnesia.Application.Common.Service.EncodeDecode;
using Carnesia.Application.CMS.Services;
using Carnesia.Application.CMS.Services.Brand;
using Carnesia.Application.CMS.Services.Category;
using Carnesia.Application.CMS.Services.FullWidthBanner;
using Carnesia.Application.CMS.Services.ChildProduct;
using Carnesia.Application.CMS.Services.CreateProduct;
using Carnesia.Application.CMS.Services.GifBanner;
using Carnesia.Application.CMS.Services.HomeCarousel;
using Carnesia.Application.CMS.Services.UnderCarouselBanner;
using Carnesia.Application.CMS.Services.ParentProduct;
using Carnesia.Application.CRM.Services.Vouchers.GeneralVoucher;
using Carnesia.Application.Vendor.Services;
using Carnesia.Application.WMS.PO.Services;
using Carnesia.Application.WMS.PO.Services.ReceivePO;
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
builder.Services.AddScoped<IReceivePO, ReceivePOService>();
builder.Services.AddScoped<IProduct, ProductService>();
builder.Services.AddScoped<IBrand, BrandService>();
builder.Services.AddScoped<IChildProduct, ChildProductService>();
builder.Services.AddScoped<ICategory, CategoryService>();
builder.Services.AddScoped<IFullWidthBanner, FullWidthBannerService>();
builder.Services.AddScoped<ICreateProduct, CreateProductService>();
builder.Services.AddScoped<IGifBanner, GifBannerService>();
builder.Services.AddScoped<IHomeCarousel, HomeCarouselService>();
builder.Services.AddScoped<IUnderCarouselBanner, UnderCarouselBannerService>();
builder.Services.AddScoped<IParentProduct, ParentProductService>();
builder.Services.AddScoped<IGeneralVoucher, GeneralVoucherService>();
builder.Services.AddScoped<IBase64, Base64Service>();
builder.Services.AddScoped<IEncodeDecode, EncodeDecodeService>();

await builder.Build().RunAsync();
