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
            int A = 0; int B = 5; int C = 2;
            if (A < B && A < C)
            {
                Console.WriteLine(A);
            }
            else if (B < A && B < C)
            {
                Console.WriteLine(B);
            }
            {
                Console.WriteLine(C);
            }
        }
    }
}
