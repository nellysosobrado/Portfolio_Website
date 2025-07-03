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

            builder.Services.AddRazorPages();
            builder.Services.AddHttpClient();
            builder.Services.Configure<OpenWeatherOptions>(
    builder.Configuration.GetSection("OpenWeather"));

            builder.Services.AddHttpClient<IWeatherService, WeatherService>();


            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddHttpClient<IProjectDataService, ProjectDataService>(client =>
            {
                var apiBaseUrl = builder.Configuration["ApiBaseUrl"];
                client.BaseAddress = new Uri(apiBaseUrl!);
            });


            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.
                     GetRequiredService<ApplicationDbContext>();
                if (dbContext.Database.IsRelational())
                {
                    //dbContext.Database.Migrate();
                    //dbContext.Database.EnsureCreated();
                    SeedData.Initialize(dbContext);
                }
            }

           
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
