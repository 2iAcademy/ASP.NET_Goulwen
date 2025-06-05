using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Movies_Exercice3.Data;
    
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews() .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
    });

builder.Services.AddDbContext<AppDbContext>(options =>
    //options.UseMySQL(builder.Configuration.GetConnectionString("mySQLConnectionLocal")));
    options.UseMySQL(builder.Configuration.GetConnectionString("mySQLConnectionDist")));
    //options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200",
                    "http://192.168.1.72:83",
                    "http://192.168.1.72:80",
                    "http://[2a02:842a:8217:8e01:265e:beff:fe3c:8d95]:83",
                    "http://[2a02:842a:8217:8e01:265e:beff:fe3c:8d95]:80",
                    "http://gdelaunay.fr")
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("Location");
        });
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
app.UseRouting();
app.UseCors("AllowSpecificOrigins");

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();