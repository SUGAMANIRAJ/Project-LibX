using Microsoft.EntityFrameworkCore;
using ProjectLibX.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

#region Configure DataContext
    builder.Services.AddDbContext<StudentContext>(options =>
    {
        options.UseSqlServer("server=STORMER-TECH\\SQLEXPRESS;Database=StudentInfo;Trusted_Connection=true;TrustServerCertificate=true;");
    });
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
