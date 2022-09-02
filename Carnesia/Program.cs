using Carnesia;
using Carnesia.Application.Common.Service.Base64;
using Carnesia.Application.Common.Service.EncodeDecode;
using Carnesia.Application.CMS.Services;
using Carnesia.Application.CMS.Services.Brand;
using Carnesia.Application.CMS.Services.BrandBanner;
using Carnesia.Application.CMS.Services.Category;
using Carnesia.Application.CMS.Services.FullWidthBanner;
using Carnesia.Application.CMS.Services.ChildProduct;
using Carnesia.Application.CMS.Services.CreateProduct;
using Carnesia.Application.CMS.Services.GifBanner;
using Carnesia.Application.CMS.Services.HomeCarousel;
using Carnesia.Application.CMS.Services.UnderCarouselBanner;
using Carnesia.Application.CMS.Services.ParentProduct;
using Carnesia.Application.CMS.Services.Products;
using Carnesia.Application.CMS.Services.BunchProduct;
using Carnesia.Application.CMS.Services.BunchSection;
using Carnesia.Application.CMS.Services.ProductList;
using Carnesia.Application.CMS.Services.CreateCampaign;
using Carnesia.Application.CMS.Services.Combo;
using Carnesia.Application.CMS.Services.OfferBanner;
using Carnesia.Application.CMS.Services.PaymentOffer;
using Carnesia.Application.CMS.Services.BlogPost;
using Carnesia.Application.CMS.Services.CampaignList;
using Carnesia.Application.CMS.Services.ToBag;
using Carnesia.Application.CRM.Services.Vouchers.GeneralVoucher;
using Carnesia.Application.CRM.Services.Vouchers.StoreVoucher;
using Carnesia.Application.CRM.Services.Vouchers.InstantVoucher;
using Carnesia.Application.CRM.Services.Vouchers.UserVoucher;
using Carnesia.Application.CRM.Services.Vouchers.ProductVoucher;
using Carnesia.Application.CRM.Services.Vouchers.AutoApply;
using Carnesia.Application.Vendor.Services;
using Carnesia.Application.WMS.PO.Services;
using Carnesia.Application.WMS.PO.Services.ReceivePO;
using Carnesia.Application.WMS.Store.Services;
using Carnesia.Application.WMS.PutAway.BinInscan;
using Carnesia.Application.WMS.StockRelocation;
using Carnesia.Application.WMS.StockTransfer.CreateTo;
using Carnesia.Application.WMS.StockTransfer.ManageTo;
using Carnesia.Application.OMS.Services.Zones;
using Carnesia.Application.OMS.Services.PendingOrder;
using Carnesia.Application.HRM.User;
using Carnesia.Application.HRM.HR;
using Carnesia.Application.HRM.PanelUser;
using Carnesia.Application.Dashboard.GenerateBill;
using Carnesia.Application.Dashboard.Orders;
using Carnesia.Application.Dashboard.ReturnRefund;
using Carnesia.Application.Dashboard.CustomerProfile;
using Carnesia.Application.Dashboard.Dashboard;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Carnesia.Application.WMS.Bin.Services;
using Carnesia.Application.WMS.PutAway.Services;
using Syncfusion.Blazor;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjY3OTMzQDMxMzgyZTM0MmUzMEtBS0dyOEpaTnpmSXZvaHNsT0doNW5HZ1l5L2J5cmRtRmtkQU5GamlQejg9");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddMudServices();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://carnesiaapi.bespokeit.io/api/") });

//meesagehandler

builder.Services.AddHttpClient("RetailSuite", client =>
{
    client.BaseAddress = new Uri("https://carnesiaapi.bespokeit.io/api/");
}).AddHttpMessageHandler<AuthorizationMessageHandler>();

builder.Services.AddTransient<AuthorizationMessageHandler>();
builder.Services.AddScoped(sp => sp.GetService<IHttpClientFactory>().CreateClient("RetailSuite"));

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, JwtAuthenticationStateProvider>();
builder.Services.AddScoped<IPurchaseOrder, PurchaseOrderService>();
builder.Services.AddScoped<IVendor, VendorServices>();
builder.Services.AddScoped<IStore, StoreService>();
builder.Services.AddScoped<IReceivePO, ReceivePOService>();
builder.Services.AddScoped<IProduct, ProductService>();
builder.Services.AddScoped<IBrand, BrandService>();
builder.Services.AddScoped<IBrandBanner, BrandBannerService>();
builder.Services.AddScoped<IChildProduct, ChildProductService>();
builder.Services.AddScoped<ICategory, CategoryService>();
builder.Services.AddScoped<IFullWidthBanner, FullWidthBannerService>();
builder.Services.AddScoped<ICreateProduct, CreateProductService>();
builder.Services.AddScoped<IGifBanner, GifBannerService>();
builder.Services.AddScoped<IHomeCarousel, HomeCarouselService>();
builder.Services.AddScoped<IUnderCarouselBanner, UnderCarouselBannerService>();
builder.Services.AddScoped<IParentProduct, ParentProductService>();
builder.Services.AddScoped<IProducts, ProductsService>();
builder.Services.AddScoped<IOfferBanner, OfferBannerService>();
builder.Services.AddScoped<IPaymentOffer, PaymentOfferService>();
builder.Services.AddScoped<IBunchProduct, BunchProductService>();
builder.Services.AddScoped<IBunchSection, BunchSectionService>();
builder.Services.AddScoped<IBlogPost, BlogPostService>();
builder.Services.AddScoped<IProductList, ProductListService>();
builder.Services.AddScoped<IToBag, ToBagService>();
builder.Services.AddScoped<ICreateCampaign, CreateCampaignService>();
builder.Services.AddScoped<ICombo, ServiceCombo>();
builder.Services.AddScoped<ICampaignList, CampaignListService>();
builder.Services.AddScoped<IGeneralVoucher, GeneralVoucherService>();
builder.Services.AddScoped<IStoreVoucher, StoreVoucherService>();
builder.Services.AddScoped<IInstantVoucher, InstantVoucherService>();
builder.Services.AddScoped<IUserVoucher, UserVoucherService>();
builder.Services.AddScoped<IProductVoucher, ProductVoucherService>();
builder.Services.AddScoped<IAutoApply, AutoApplyService>();
builder.Services.AddScoped<IUser, UserService>();
builder.Services.AddScoped<IHR, HRService>();
builder.Services.AddScoped<IPanelUser, PanelUserService>();
builder.Services.AddScoped<IBase64, Base64Service>();
builder.Services.AddScoped<IEncodeDecode, EncodeDecodeService>();
builder.Services.AddScoped<IZones, ZonesService>();
builder.Services.AddScoped<IPendingOrder, PendingOrderService>();
builder.Services.AddScoped<IBin, BinService>();
builder.Services.AddScoped<IGenerateBill, GenerateBillService>();
builder.Services.AddScoped<IOrders, OrdersService>();
builder.Services.AddScoped<IReturnRefund, ReturnRefundService>();
builder.Services.AddScoped<ICustomerProfile, CustomerProfileService>();
builder.Services.AddScoped<IDashboard, DashboardService>();
builder.Services.AddScoped<IPutAway, PutAwayService>();
builder.Services.AddScoped<IStockRelocation, StockRelocationService>();
builder.Services.AddScoped<ICreateTo, CreateToService>();
builder.Services.AddScoped<IManageTo, ManageToService>();
builder.Services.AddScoped<IBinInscan, BinInscanService>();
builder.Services.AddSyncfusionBlazor(option => { option.IgnoreScriptIsolation = true; });
await builder.Build().RunAsync();
