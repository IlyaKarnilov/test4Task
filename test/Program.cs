using Microsoft.EntityFrameworkCore;
using test.Areas.Identity.Data;
using test.Data;
using test.Services;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<testContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("testContextConnection")));


builder.Services.AddDefaultIdentity<testUser>(options => {
options.SignIn.RequireConfirmedAccount = false;
options.Password.RequireDigit = false;
options.Password.RequireLowercase = false;
options.Password.RequireUppercase = false; 
options.Password.RequireNonAlphanumeric = false; 
options.Password.RequiredLength = 1; 
}).AddEntityFrameworkStores<testContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});
builder.Services.AddScoped<UserManagementService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Users}/{action=Users}/{id?}");
app.MapRazorPages();

app.Run();
