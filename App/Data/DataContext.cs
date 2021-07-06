using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace App
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=app.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var students = new Student[] {
                new Student { Id = 1, FirstName = "Phillipe", LastName = "Cousteau",  Age=53, GrYear=Student.Classification.Senior},
                new Student { Id = 2, FirstName = "Don", LastName = "Julio", Age=25, GrYear=Student.Classification.Freshman},
                new Student { Id = 3, FirstName = "Susan", LastName = "Lawrence", Age=37, GrYear=Student.Classification.Sophomore}
            };

            modelBuilder.Entity<Student>().HasData(students);
            

            var grades = new Grade[] {
                new Grade { Id = 1, StudentId=1, CourseName="407 Shark Metabolism", GradeVal=0.78},
                new Grade { Id = 2, StudentId=1, CourseName="411 Anemone Poisons", GradeVal=0.88},
                new Grade { Id = 3, StudentId=1, CourseName="420 Reef Pollution", GradeVal=0.97},
                new Grade { Id = 4, StudentId=2, CourseName="103 Agave Chemistry", GradeVal=0.87},
                new Grade { Id = 5, StudentId=2, CourseName="101 Accounting", GradeVal=0.98},
                new Grade { Id = 6, StudentId=2, CourseName="107 Music", GradeVal=0.79},
                new Grade { Id = 7, StudentId=3, CourseName="203 English Literature", GradeVal=0.87},
                new Grade { Id = 8, StudentId=3, CourseName="219 College Algebra", GradeVal=0.98},
                new Grade { Id = 9, StudentId=3, CourseName="275 Industrial Arts", GradeVal=0.81}
            };

                      

            modelBuilder.Entity<Grade>().HasData(grades);

            base.OnModelCreating(modelBuilder);
        }
    }
}