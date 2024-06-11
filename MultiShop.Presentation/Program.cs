using Microsoft.EntityFrameworkCore;
using MultiShop.Business;
using MultiShop.Business.Services;
using MultiShop.Data;
using MultiShop.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();//1) Kontroller views alt yapýsýný entegre etme
//Servis Entegrasyonu
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRatingService, ProductRatingService>();

//Repository Entegrasypnu
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ISliderRepository, SliderRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductRatingRepository, ProductRatingRepository>();
//4: for connection Db
//bunun set edildiði yer MultiShopDbContext içerisinde constroctor metottur.
builder.Services.AddDbContext<MultiShopDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MultiShopConnectionStr_Prod"));
});
builder.Services.AddAutoMapper(typeof(CategoryMappingProfile));
builder.Services.AddAutoMapper(typeof(SliderMappingProfile));
builder.Services.AddAutoMapper(typeof(ProductMappingProfile));
var app = builder.Build();

app.MapControllerRoute("default",pattern : "{Controller=Home}/{action=Index}/{id?}");//2
app.UseStaticFiles();//3
//? Optinal

app.Run();