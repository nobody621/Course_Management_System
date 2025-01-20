using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            x = 0;
            y = 2;

            Console.WriteLine(++x);
            Console.WriteLine(y);
            Console.WriteLine(x+y);

            Console.ReadKey();
        }
    }
}
