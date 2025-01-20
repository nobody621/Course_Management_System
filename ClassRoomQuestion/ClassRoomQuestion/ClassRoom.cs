using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomQuestion
{
    internal class ClassRoom
    {
        private string name;
        private int space;
        private Teacher teacher;
        private List<Student> students;

        public ClassRoom(string name, int space, Teacher teacher)
        {
            this.name = name;
            this.space = space;
            this.teacher = teacher; // Set teacher
            this.students = new List<Student>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Space
        {
            get { return space; }
            set { space = value; }
        }

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        // Methods
        public void AddTeacher(Teacher teacher)
        {
            this.teacher = teacher; // Add teacher to classroom
            Console.WriteLine($"Teacher {teacher.Name} has been assigned to the classroom.");
        }

        public void AddStudent(Student student)
        {
            if (students.Count < space)
            {
                students.Add(student);
                Console.WriteLine($"Student {student.Name} has been added to the classroom.");
            }
            else
            {
                Console.WriteLine("Classroom is full. Cannot add more students.");
            }
        }

        public void RemoveStudent(Student student)
        {
            if (students.Contains(student))
            {
                students.Remove(student);
                Console.WriteLine($"Student {student.Name} has been removed from the classroom.");
            }
            else
            {
                Console.WriteLine("Student not found in the classroom.");
            }
        }

    }
}
