using System;

class Parallelepiped
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        string rowToPrint = $"+{new string('~', size - 2)}+{new string('.', 2 * size + 1)}";

        Console.WriteLine(rowToPrint);

        int dotsLeft = 0;
        int dotsRight = 2 * size;

        for (int row = 0; row < 2 * size + 1; row++)
        {
            rowToPrint = $"|{new string('.', dotsLeft)}\\{new string('~', size - 2)}\\{new string('.', dotsRight)}";
            Console.WriteLine(rowToPrint);
            dotsLeft++;
            dotsRight--;
        }

        dotsLeft--;
        dotsRight++;

        for (int row = 0; row < 2 * size + 1; row++)
        {
            rowToPrint = $"{new string('.', dotsRight)}\\{new string('.', dotsLeft)}|{new string('~', size - 2)}|";
            Console.WriteLine(rowToPrint);
            dotsLeft--;
            dotsRight++;
        }

        rowToPrint = $"{new string('.', 2 * size + 1)}+{new string('~', size - 2)}+";
        Console.WriteLine(rowToPrint);
    }
}