using Microsoft.EntityFrameworkCore;
using DAL.Models;
using DAL.Data;

namespace PortfolioAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // L�gg till controllers
            builder.Services.AddControllers();

            // L�gg till Swagger (OpenAPI)
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            // L�gg till databas
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // Migrera och seeda databas
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                db.Database.Migrate();
                SeedData.Initialize(db);
            }

            // Aktivera Swagger i utvecklingsl�ge
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(); // <- Det h�r g�r s� du f�r en snygg Swagger-sida i webbl�saren
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
