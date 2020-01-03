using System;
using Microsoft.EntityFrameworkCore;
using UniversityDemo.Models;

namespace UniversityDemo.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {
        }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<EnrollmentModel> Enrollments { get; set; }
        public DbSet<CourseModel> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentModel>().HasData(
                new StudentModel
                {
                    StudentId = 1,
                    FirstName = "William",
                    LastName = "Shakespeare",
                    EnrollmentDate = DateTime.Now
                },
                new StudentModel
                {
                    StudentId = 2,
                    FirstName = "James",
                    LastName = "Blake",
                    EnrollmentDate = DateTime.Now

                },
                new StudentModel
                {
                    StudentId = 3,
                    FirstName = "Franklin",
                    LastName = "Stein",
                    EnrollmentDate = DateTime.Now
                },
                new StudentModel
                {
                    StudentId = 4,
                    FirstName = "Craig",
                    LastName = "Morris",
                    EnrollmentDate = DateTime.Now
                }
            );
            modelBuilder.Entity<CourseModel>().HasData(
                new CourseModel { CourseId = 123, Credits = 3, Title = "Math" },
                new CourseModel { CourseId = 234, Credits = 6, Title = "Bio" },
                new CourseModel { CourseId = 432, Credits = 12, Title = "Physics" },
                new CourseModel { CourseId = 110, Credits = 12, Title = "Chemisty" }
            );
            modelBuilder.Entity<EnrollmentModel>().HasData(
                new EnrollmentModel {EnrollmentId = 1, StudentId = 1, Grade = 'A', CourseId = 123},
                new EnrollmentModel {EnrollmentId = 2, StudentId = 2, Grade = 'B', CourseId = 123},
                new EnrollmentModel {EnrollmentId = 3, StudentId = 3, Grade = 'A', CourseId = 432},
                new EnrollmentModel {EnrollmentId = 4, StudentId = 4, Grade = 'C', CourseId = 110}
            );                            
        }
    }
}
