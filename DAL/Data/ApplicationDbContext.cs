﻿using Microsoft.EntityFrameworkCore;
using DAL.Models;

namespace DAL.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Project> Projects { get; set; }


}