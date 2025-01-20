using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherPerson
{
    internal class Teacher:Person
    {
        private string teacherId;

        public string TeacherId
        {
            get { return name }
            set { teacherId = value; }
        }

        public Teacher(string name, int age, string teacherId) : base(name, age) {
            this.teacherId = teacherId;
        }
    }
}
