﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace RandomNumbersGeneratorEvents.DataModel
{
    public class AppDbContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(GlobalVars.ConnectionString);
    } 

    public DbSet<Product> Products { get; set; }
  }
}
