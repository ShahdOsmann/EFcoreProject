using EFcoreProject;
using EFcoreProject.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace EFcoreProject.Data
{
    public class AppDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-3BGRV7T\\MSSQLSERVER1;DataBase=EFCoreProjectDB;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 
        }

        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<Instructor> Instructors { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<CourseSession> CourseSessions { get; set; } = null!;
        public DbSet<CourseStudent> CourseStudents { get; set; } = null!;
        public DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;

    }
}
