using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrandCircusUniversity.GrandCircusUniversity2
{
    public class ContextClass : DbContext 
    {
        public ContextClass(DbContextOptions<ContextClass> options) : base(options) 
        {

        }

        public DbSet<Course> Course { get; set; }

        public DbSet<Student> Student { get; set; }

        public DbSet<StudentCourse> StudentCourse { get; set; }

        public DbSet<Administrator> Administrator { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuidler)
        {
            modelBuidler.Entity<Course>()
                .HasKey(c => c.CourseId);
            #region OwnedTypeSeed
            modelBuidler.Entity<Course>().HasData(
                new { CourseId = 1, CourseName = "C#", isFullTime = true, isPartTime = false },
                new { CourseId = 2, CourseName = "JavaScript", isFullTime = false, isPartTime = true },
                new { CourseId = 3, CourseName = ".Net Core", isFullTime = true, isPartTime = false });
            #endregion
        }
    }
}
