using Domain.Entities;
using Domain.NGSContext;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddIdentity<User, Role>(option =>
{
    option.Password.RequireDigit = false;
    option.Password.RequireLowercase = false;
    option.Password.RequireNonAlphanumeric = false;
    option.Password.RequireUppercase = false;
    option.Password.RequireDigit = false;
    option.Password.RequiredLength = 8;
    option.User.RequireUniqueEmail = true;    
}).AddEntityFrameworkStores<NGSContext>();
builder.Services.AddAuthorization();
builder.Services.AddAuthentication();
builder.Services.AddScoped<NGSContext>();
builder.Services.AddDbContext<NGSContext>(options => options.UseSqlServer(builder.Configuration["Database:ConnectionString"]));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
