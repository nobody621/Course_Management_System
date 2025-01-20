using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Teacher:Person,IReportable
    {
        private string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            this.subject = subject;
        }

        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Subject : " + subject);
        }
    }


}
