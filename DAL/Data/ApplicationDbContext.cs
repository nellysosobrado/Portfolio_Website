using Microsoft.EntityFrameworkCore;
using DAL.Models;

namespace DAL.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    //public DbSet<Project> Projects => Set<Project>();
    public DbSet<Project> Projects { get; set; }

    //public DbSet<ContactMessage> ContactMessages { get; set; }

}