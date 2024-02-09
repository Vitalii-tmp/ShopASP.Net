using InternetStore.Domain;
using InternetStore.Domain.Repositories.Abstract;
using InternetStore.Domain.Repositories.EntityFramework;
using InternetStore.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
    

builder.Services.AddTransient<ITextFieldsRepository, EfTextFieldsRepository>();
builder.Services.AddTransient<IProductsItemsRepository, EfProductsItemsRepository>();
builder.Services.AddTransient<DataManager>();
builder.Configuration.Bind("Project", new Config());
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));


builder.Services.AddIdentity<IdentityUser, IdentityRole>(opts =>
{
    opts.User.RequireUniqueEmail = true;
    opts.Password.RequiredLength = 6;
    opts.Password.RequireNonAlphanumeric = false;
    opts.Password.RequireDigit = false;
    opts.Password.RequireLowercase = false;
    opts.Password.RequireUppercase = false;
}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "myCompanyAuth";
    options.Cookie.HttpOnly = true;
    options.LoginPath = "/account/login";
    options.AccessDeniedPath = "/account/accessdenied";
    options.SlidingExpiration = true;
});


builder.Services.AddAuthorization(x =>
{
    x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
});

// Add services to the container.
builder.Services.AddControllersWithViews(x => { x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea")); });
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

// connect authorization and authentication
app.UseAuthorization();
app.UseAuthentication();
app.UseCookiePolicy();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute("default", "/{ action = Index}/{ id ?}");

});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "admin",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.Run();