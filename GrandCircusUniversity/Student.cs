using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrandCircusUniversity.GrandCircusUniversity2
{
    public class Student
    {
        public int StudentId { get; set; }

        [Display(Name = "First Name")]
        public string StudentFirstName { get; set; }

        [Display(Name = "Last Name")]
        public string StudentLastName { get; set; }

        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        public Administrator Administrator { get; set; }

        [Display(Name = "My Courses")]
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }

    public class StudentCourse
    {
        public int StudentId { get; set; }

        public Student Student { get; set; }

        public int StudentCourseId { get; set; }

        public Course Course { get; set; }
    }
}
