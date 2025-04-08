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
            int A = Int32.Parse(Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = A; i <= B; i++)
            {
                cnt += i;
            }
            Console.WriteLine(cnt);
        }
    }
}
