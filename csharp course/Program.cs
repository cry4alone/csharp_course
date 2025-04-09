using System;

namespace csharp_course
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = 567;
            int[] res = GetNums(num);
            Console.WriteLine($"Ones: {res[0]}, Tens: {res[1]}");
        }

        public static int[] GetNums(int num)
        {
            int ones = num % 10;
            int tens = (num / 10) % 10;
            return new int[] { ones, tens };
        }
    }
}