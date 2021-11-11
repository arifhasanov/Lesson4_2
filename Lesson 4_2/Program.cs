using System;

namespace Lesson_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some numbers separated with spaces ' ' and then press ENTER");
            string s = Console.ReadLine();

            string[] subs = s.Split(' ');
            int total = 0;

            foreach (var sub in subs)
            {
                int number = 0;
                if(int.TryParse(sub, out number))
                {
                    total += number;
                }
            }

            Console.WriteLine($"Total of extracted numbers is: {total}");
        }
    }
}
