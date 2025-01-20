using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherPerson
{
    internal class Student:Person
    {
        private string studentId;

        public Student(string name, int age, string studentId) : base(name, age)
        {
            this.studentId = studentId;
        }
    }
}
