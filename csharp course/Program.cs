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
            float a = 10;
            Console.WriteLine(Perimeter(a));
        }

        public static float Perimeter(float a)
        {
            float P = 4 * a;
            return P;
        }
    }
}
