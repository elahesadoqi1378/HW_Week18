using Microsoft.AspNetCore.Hosting;
using WebApplication2.Contracts.Service;
using WebApplication2.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();

// Adding services to the DI container
builder.Services.AddRazorPages();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Session timeout duration
    options.Cookie.HttpOnly = true;                // Secure cookie
    options.Cookie.IsEssential = true;             // Ensures compatibility with GDPR
});



// Build the app
var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Use Session middleware
app.UseSession();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
