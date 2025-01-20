using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomQuestion
{
    internal class Student
    {
        private string name;
        private int age;
        private string id;

        public Student(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
