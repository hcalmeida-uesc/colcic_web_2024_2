using System;
using Microsoft.EntityFrameworkCore;
using UescColcicAPI.Core;

namespace UescColcicAPI.Services.BD;

public class UescColcicDBContext : DbContext
{
   public DbSet<Student> Students { get; set; }
   public DbSet<Skill> Skills { get; set; }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
        modelBuilder.Entity<Skill>().HasKey(x => x.SkillId);
        modelBuilder.Entity<Student>().HasKey(x => x.StudentId);
        modelBuilder.Entity<Student>().HasMany<Skill>(x => x.Skills).WithOne(x => x.Student).HasForeignKey(x => x.StudentId);

   }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
       optionsBuilder.UseSqlite("Data Source=/home/helder/_dev/colcic_web_2024_2/backend/UescColcicAPI/UescColcicAPI.db");
   }
}
