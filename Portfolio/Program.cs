using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Portfolio.Services;
using Services.Interfaces;
using Services.Services;

namespace Portfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddHttpClient();
            builder.Services.Configure<OpenWeatherOptions>(
    builder.Configuration.GetSection("OpenWeather"));

            builder.Services.AddHttpClient<IWeatherService, WeatherService>();

            // Lägg till databaskoppling
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddHttpClient<IProjectDataService, ProjectDataService>(client =>
            {
                client.BaseAddress = new Uri("https://portfolioapi20250517155004-a3abhtfaecf6ekdh.swedencentral-01.azurewebsites.net");
            });

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.
                     GetRequiredService<ApplicationDbContext>();
                if (dbContext.Database.IsRelational())
                {
                    dbContext.Database.Migrate();
                    dbContext.Database.EnsureCreated();
                    SeedData.Initialize(dbContext);
                }
            }

            

            // 🟡 Lägg till databasinitiering + seeding
            //using (var scope = app.Services.CreateScope())
            //{
            //    var services = scope.ServiceProvider;
            //    var context = services.GetRequiredService<ApplicationDbContext>();

            //    // Skapa databasen om den inte finns (utan migrations)
            //    context.Database.EnsureCreated();

            //    // Kör seeding
            //    SeedData.Initialize(context);
            //}

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapRazorPages()
               .WithStaticAssets();

            app.Run();
        }
    }
}
