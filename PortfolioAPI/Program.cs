using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models; 
using DAL.Models;
using DAL.Data;

namespace PortfolioAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Lägg till controllers
            builder.Services.AddControllers();

            // Lägg till Swagger (OpenAPI)
            builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Portfolio API",
                    Version = "v1",
                    Description = "API för Nylegna Kir Sosobrados utvecklarportfölj"
                });
            });

            // Lägg till databas
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

            // 🟢 Aktivera Swagger alltid (även i produktion – för test/demo)
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.MapGet("/", context =>
            {
                context.Response.Redirect("/swagger");
                return Task.CompletedTask;
            });


            app.Run();
        }
    }
}
