using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    internal class Department
    {
        public class Department
        {
            public string Name { get; set; }
            public List<Course> Courses { get; set; }

            public Department(string name)
            {
                Name = name;
                Courses = new List<Course>();
            }

            public void AddCourse(Course course)
            {
                Courses.Add(course);
            }

            public void RemoveCourse(Course course)
            {
                Courses.Remove(course);
            }
        }
    }
}
