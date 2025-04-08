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
            int num = 1000;
            int endNum = 1100;
            int percent = Int32.Parse(Console.ReadLine());
            // 5 %
            while (num <= endNum)
            {
                num += percent * (num / 100);
            }
            Console.WriteLine(num);
        }
    }
}
