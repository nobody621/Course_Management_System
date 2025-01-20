using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Student:Person,IReportable
    {
        private char grade;

        public char Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student(string name, int age, char grade):base (name, age)
        {
            this.grade = grade;
        }

        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Grade : " + Grade);
        }
    }
}
