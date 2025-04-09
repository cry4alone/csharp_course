using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_course
{
    public class Program
    {
        static void Main(string[] args)
        {
            int A = 0; int B = 5; int C = 2;
            Console.WriteLine(getMin(A, B, C));

        }
       public static int getMin(int A, int B, int C)
        {
            if (A < B && A < C)
            {
                return A;
            }
            else if (B < A && B < C)
            {
                return B;
            }
            return C;
        }


    }
}
