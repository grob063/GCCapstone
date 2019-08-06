using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrandCircusUniversity.GrandCircusUniversity2
{
    public class Administrator
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Course> Course { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }

    }
}
