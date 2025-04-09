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
            int Sign(float X) {
                if (X == 0)
                {
                    return 0;
                }
                else if (X > 0) {
                    return 1;
                }
                return -1;
            }

            float A = 3;
            float B = 5;
            Console.WriteLine(Sign(A) + Sign(B));
        }
    }
}
