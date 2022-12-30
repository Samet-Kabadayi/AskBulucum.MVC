using Microsoft.AspNetCore.Authentication.Cookies;
using Services.DependencyResolvers;
using System.Reflection;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServiceRegister();

//builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
//builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutoFacBusinessModule()));

var assembly = Assembly.GetExecutingAssembly();
builder.Services.AddAutoMapper(assembly);
//builder.Services.LoadServiceLayerExtension();
// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(opts =>
    {
        opts.Cookie.Name = ".Bulucum.auth";
        opts.ExpireTimeSpan = TimeSpan.FromDays(7);
        opts.SlidingExpiration = false;
        opts.LoginPath = "/Seeker/Auth/Login";
        opts.LogoutPath = "/Home/Index";
        opts.AccessDeniedPath = "/Home/AccessDenied";
    });

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

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
    name: "Seeker",
    areaName: "Seeker",
    pattern: "Seeker/{controller=Auth}/{action=SeekerLogin}/{id?}"
    );
    endpoints.MapDefaultControllerRoute();
});

app.Run();
