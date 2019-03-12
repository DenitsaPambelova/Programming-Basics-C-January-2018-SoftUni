using System;

class Axe
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int left = 3 * size;
        int middle = 0;
        int right = 2 * size - 2;
        string rowToPrint = "";

        for (int row = 0; row < size; row++)
        {
            rowToPrint = $"{new string('-', left)}*{new string('-', middle)}*{new string('-', right)}";
            Console.WriteLine(rowToPrint);
            middle++;
            right--;
        }

        middle--;
        right++;

        for (int row = 0; row < size / 2; row++)
        {
            rowToPrint = $"{new string('*', left + 1)}{new string('-', middle)}*{new string('-', right)}";
            Console.WriteLine(rowToPrint);
        }

        for (int row = 0; row < size / 2 - 1; row++)
        {
            rowToPrint = $"{new string('-', left)}*{new string('-', middle)}*{new string('-', right)}";
            Console.WriteLine(rowToPrint);
            left--;
            middle += 2;
            right--;
        }

        middle += 2;
        rowToPrint = $"{new string('-', left)}{new string('*', middle)}{new string('-', right)}";
        Console.WriteLine(rowToPrint);
    }
}