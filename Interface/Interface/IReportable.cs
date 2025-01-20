using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IReportable
    {
        public void GenerateReport();

        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Hello");
        }
    }
}
