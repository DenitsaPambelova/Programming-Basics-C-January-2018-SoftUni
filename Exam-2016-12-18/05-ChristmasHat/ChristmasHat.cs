using System;

class ChristmasHat
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int dots = 2 * size - 1;
        int dashes = 0;
        string rowToPrint = $"{new string('.', dots)}/|\\{new string('.', dots)}";

        Console.WriteLine(rowToPrint);
        rowToPrint = $"{new string('.', dots)}\\|/{new string('.', dots)}";
        Console.WriteLine(rowToPrint);

        for (int row = 0; row < 2 * size; row++)
        {
            rowToPrint = $"{new string('.', dots)}*{new string('-', dashes)}*{new string('-', dashes)}*{new string('.', dots)}";
            Console.WriteLine(rowToPrint);
            dots--;
            dashes++;
        }
        for (int row = 0; row < 3; row++)
        {
            if (row == 1)
            {
                for (int j = 0; j < 2 * size; j++)
                {
                    Console.Write("*.");
                }
                Console.WriteLine("*");
            }
            else
            {
                rowToPrint = new string('*', size * 4 + 1);
                Console.WriteLine(rowToPrint);
            }
        }
    }
}