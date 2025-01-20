using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    internal class Course
    {
        public class Course
        {
            public string Title { get; set; }
            public List<Professor> Professors { get; set; }
            public Classroom Classroom { get; set; }

            public Course(string title)
            {
                Title = title;
                Professors = new List<Professor>();
            }

            public void AssignClassroom(Classroom classroom)
            {
                Classroom = classroom;
            }
        }
    }
}
