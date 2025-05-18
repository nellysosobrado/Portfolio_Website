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

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Portfolio API",
                    Version = "v1",
                    Description = "API for portfolio project"
                });
            });
            builder.Services.AddControllers()
    .AddNewtonsoftJson(); 



            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.WithOrigins(
                        "https://localhost:7087", 
                        "https://portfolionylegna-duhegge3eph2eve9.swedencentral-01.azurewebsites.net" 
                    )
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });
            builder.Services.AddAutoMapper(typeof(MappingProfile));


            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                db.Database.Migrate();
                SeedData.Initialize(db);
            }

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();
            app.UseCors(); 
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
