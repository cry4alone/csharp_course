using System;

namespace csharp_course
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели (1-7):");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int numA))
            {
                string weekday = GetWeekday(numA);
                Console.WriteLine(weekday);
            }
        }

        public static string GetWeekday(int num)
        {
            switch (num)
            {
                case 1:
                    return "Понедельник";
                case 2:
                    return "Вторник";
                case 3:
                    return "Среда";
                case 4:
                    return "Четверг";
                case 5:
                    return "Пятница";
                case 6:
                    return "Суббота";
                case 7:
                    return "Воскресенье";
                default:
                    return "Нет такого дня";
            }
        }
    }
}