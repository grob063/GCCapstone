using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrandCircusUniversity.GrandCircusUniversity2
{
    public class Course
    {
        public int CourseId { get; set; }

        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        public bool isFullTime { get; set; }

        public bool isPartTime { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
