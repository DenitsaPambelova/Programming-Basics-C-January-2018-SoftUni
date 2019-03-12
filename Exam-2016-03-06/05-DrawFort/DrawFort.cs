using System;

namespace _05_DrawFort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int cover = size / 2;
            int dash = 2 * size - (2 * (size / 2) + 4);
            int rows = size - 3;
            int space = 2 * size - 2;

            if (size < 5)
            {
                rows++;
            }

            Console.WriteLine($"/{new string('^', cover)}\\{new string ('_', dash)}/{new string('^', cover)}\\");

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"|{new string(' ', space)}|");
            }

            if (size > 4)
            {
                Console.WriteLine($"|{new string(' ', cover + 1)}{new string('_', dash)}{new string(' ', cover + 1)}|");
            }

            Console.WriteLine($"\\{new string('_', cover)}/{new string(' ', dash)}\\{new string('_', cover)}/");
        }
    }
}
