using ESCOOTERRENT.Repositories;
using ESCOOTERRENT.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IScooterRepository, ScooterRepository>();
builder.Services.AddSingleton<IStoreRepository, StoreRepository>();
builder.Services.AddSingleton<ITypeRepository, TypeRepository>();
builder.Services.AddSingleton<IScooterService, ScooterService>();
builder.Services.AddSingleton<IStoreService, StoreService>();
builder.Services.AddSingleton<ITypeService, TypeService>();
builder.Services.AddAutoMapper(typeof(MapperService));

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();