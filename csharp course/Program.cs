using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] nums = new float[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            float sum = 0;
            foreach (float x in nums)
            {
                sum += x;
            }
            Console.WriteLine(sum);
        }
    }
}
