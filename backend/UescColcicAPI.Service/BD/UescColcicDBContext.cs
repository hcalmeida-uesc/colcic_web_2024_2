using System;
using Microsoft.EntityFrameworkCore;
using UescColcicAPI.Core;

namespace UescColcicAPI.Services.BD;

public class UescColcicDBContext : DbContext
{
   DbSet<Student> Students { get; set; }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
       modelBuilder.Entity<Student>().HasKey(x => x.StudentId);
   }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
       optionsBuilder.UseSqlite("Data Source=UescColcicAPI.db");
   }
}
