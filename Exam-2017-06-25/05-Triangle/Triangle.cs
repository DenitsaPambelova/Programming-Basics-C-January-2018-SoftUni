using System;

class Triangle
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int dots = 1;
        int spaces = 1;
        int hashtags = 2 * size - 1;
        string rowToPrint = new string('#', 4 * size + 1);

        Console.WriteLine(rowToPrint);

        for (int row = 1; row <= size; row++)
        {
            rowToPrint = $"{new string('.', dots)}{new string('#', hashtags)}";
            Console.Write(rowToPrint);

            if (row != size / 2 + 1)
            {
                Console.Write(new string(' ', spaces));
            }
            else
            {
                for (int col = 0; col < (spaces - 3) / 2; col++)
                {
                    Console.Write(" ");
                }

                Console.Write("(@)");

                for (int col = 0; col < (spaces - 3) / 2; col++)
                {
                    Console.Write(" ");
                }
            }

            rowToPrint = $"{new string('#', hashtags)}{new string('.', dots)}";
            Console.WriteLine(rowToPrint);
            dots++;
            spaces += 2;
            hashtags -= 2;
        }

        dots = size + 1;
        hashtags = 2 * size - 1;

        for (int row = 0; row < size; row++)
        {
            rowToPrint = $"{new string('.', dots)}{new string('#', hashtags)}{new string('.', dots)}";
            Console.WriteLine(rowToPrint);
            dots++;
            hashtags -= 2;
        }
    }
}