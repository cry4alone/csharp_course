using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 567;
            int ones = num % 10;
            int two = num % 100 / 10;
            Console.WriteLine("Единицы:"+ ones);
            Console.WriteLine("Десятки:"+two);
        }
    }
}
