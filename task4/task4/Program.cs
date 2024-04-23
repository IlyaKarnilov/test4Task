using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using task4.Data;
using task4.Data.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    // ��������� ������
    options.Password.RequireDigit = false; // �� ��������� ������� �����
    options.Password.RequireLowercase = false; // �� ��������� ������� �������� ����
    options.Password.RequireUppercase = false; // �� ��������� ������� ��������� ����
    options.Password.RequireNonAlphanumeric = false; // �� ��������� ������� ����������� ��������
    options.Password.RequiredLength = 1; // ����������� ����� ������
})
.AddEntityFrameworkStores<DataContext>()
.AddDefaultTokenProviders();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

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
app.MapRazorPages();

app.Run();
