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
using Carnesia.Application.CMS.Services.Products;
using Carnesia.Application.CMS.Services.ProductList;
using Carnesia.Application.CMS.Services.CreateCampaign;
using Carnesia.Application.CMS.Services.BlogPost;
using Carnesia.Application.CMS.Services.CampaignList;
using Carnesia.Application.CMS.Services.ToBag;
using Carnesia.Application.CRM.Services.Vouchers.GeneralVoucher;
using Carnesia.Application.CRM.Services.Vouchers.StoreVoucher;
using Carnesia.Application.CRM.Services.Vouchers.InstantVoucher;
using Carnesia.Application.CRM.Services.Vouchers.UserVoucher;
using Carnesia.Application.CRM.Services.Vouchers.ProductVoucher;
using Carnesia.Application.Vendor.Services;
using Carnesia.Application.WMS.PO.Services;
using Carnesia.Application.WMS.PO.Services.ReceivePO;
using Carnesia.Application.WMS.Store.Services;
using Carnesia.Application.OMS.Services.Zones;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Carnesia.Application.WMS.Bin.Services;

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
builder.Services.AddScoped<IProducts, ProductsService>();
builder.Services.AddScoped<IBlogPost, BlogPostService>();
builder.Services.AddScoped<IProductList, ProductListService>();
builder.Services.AddScoped<IToBag, ToBagService>();
builder.Services.AddScoped<ICreateCampaign, CreateCampaignService>();
builder.Services.AddScoped<ICampaignList, CampaignListService>();
builder.Services.AddScoped<IGeneralVoucher, GeneralVoucherService>();
builder.Services.AddScoped<IStoreVoucher, StoreVoucherService>();
builder.Services.AddScoped<IInstantVoucher, InstantVoucherService>();
builder.Services.AddScoped<IUserVoucher, UserVoucherService>();
builder.Services.AddScoped<IProductVoucher, ProductVoucherService>();
builder.Services.AddScoped<IBase64, Base64Service>();
builder.Services.AddScoped<IEncodeDecode, EncodeDecodeService>();
builder.Services.AddScoped<IZones, ZonesService>();
builder.Services.AddScoped<IBin, BinService>();

await builder.Build().RunAsync();
