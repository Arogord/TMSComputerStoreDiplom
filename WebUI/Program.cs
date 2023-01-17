using Abststract.common.Abstract;
using AppLogic.bll.Service;
using DBWorker.dal.EF;
using System;

var builder = WebApplication.CreateBuilder(args);

//подключаем конфиг из appsetting.json
builder.Configuration.Bind("Project", new Config());

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
//подключаем контекст БД
//builder.Configuration.Add
//builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));
//builder.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));
//builder.Services.Add
var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=List}/{id?}");

app.Run();
