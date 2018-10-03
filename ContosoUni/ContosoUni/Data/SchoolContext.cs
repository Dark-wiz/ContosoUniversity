using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUni.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUni.Data
{
    public class SchoolContext : DbContext
    {
        //public SchoolContext(DbContextOptions<SchoolContext>options) : base(options)
        //{
            
        //}

        public DbSet<Course> Courses{ get; set; }
        public DbSet<Enrollment> Enrollments{ get; set; }
        public DbSet<Student> Students{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
        }
        //create db connection without the need of context constructor
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=ContosoUniversity2;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(builder);
        }
    }
}
