using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    internal class Professor
    {
        public class professor
        {
            public string Name { get; set; }
            public List<Course> Courses { get; set; }

            public Professor(string name)
            {
                Name = name;
                Courses = new List<Course>();
            }

            public void AssignCourse(Course course)
            {
                if (!Courses.Contains(course))
                {
                    Courses.Add(course);
                    course.Professors.Add(this);
                }
            }
        }
    }
}
