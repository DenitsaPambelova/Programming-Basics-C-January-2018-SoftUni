using System;

class Hourglass
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int dots = 2;
        int ets = 2 * size - 5;
        string rowToPrint = new string('*', 2 * size + 1);

        Console.WriteLine(rowToPrint);
        rowToPrint = $".*{new string(' ', 2 * size - 3)}*.";
        Console.WriteLine(rowToPrint);

        for (int row = 0; row < size - 2; row++)
        {
            rowToPrint = $"{new string('.', dots)}*{new string('@', ets)}*{new string('.', dots)}";
            Console.WriteLine(rowToPrint);
            dots++;
            ets -= 2;
        }

        rowToPrint = $"{new string('.', dots)}*{new string('.', dots)}";
        Console.WriteLine(rowToPrint);
        dots--;
        ets = 0;

        for (int row = 0; row < size - 2; row++)
        {
            rowToPrint = $"{new string('.', dots)}*{new string(' ', ets)}@{new string(' ', ets)}*{new string('.', dots)}";
            Console.WriteLine(rowToPrint);
            dots--;
            ets++;
        }

        rowToPrint = $".*{new string('@', 2 * size - 3)}*.";
        Console.WriteLine(rowToPrint);
        rowToPrint = new string('*', 2 * size + 1);
        Console.WriteLine(rowToPrint);
    }
}