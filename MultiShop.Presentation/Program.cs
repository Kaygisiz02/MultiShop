using Microsoft.EntityFrameworkCore;
using MultiShop.Business;
using MultiShop.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();//1) Kontroller views alt yap�s�n� entegre etme
//4: for connection Db
//bunun set edildi�i yer MultiShopDbContext i�erisinde constroctor metottur.
builder.Services.AddDbContext<MultiShopDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MultiShopConnectionStr_Prod"));
});
builder.Services.AddAutoMapper(typeof(CategoryMappingProfile));
builder.Services.AddAutoMapper(typeof(CategoryMappingProfile));
var app = builder.Build();

app.MapControllerRoute("default",pattern : "{Controller=Home}/{action=Index}/{id?}");//2
app.UseStaticFiles();//3
//? Optinal

app.Run();