using System;

class Fox
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int stars = 1;
        int dashes = 2 * size - 1;
        string rowToPrint = "";

        for (int row = 0; row < size; row++)
        {
            rowToPrint = $"{new string('*', stars)}\\{new string('-', dashes)}/{new string('*', stars)}";
            Console.WriteLine(rowToPrint);
            stars++;
            dashes -= 2;
        }

        stars = size / 2;
        dashes = size;

        for (int row = 0; row < size / 3; row++)
        {
            rowToPrint = $"|{new string('*', stars)}\\{new string('*', dashes)}/{new string('*', stars)}|";
            Console.WriteLine(rowToPrint);
            stars++;
            dashes -= 2;
        }

        stars = 2 * size - 1;
        dashes = 1;

        for (int row = 0; row < size; row++)
        {
            rowToPrint = $"{new string('-', dashes)}\\{new string('*', stars)}/{new string('-', dashes)}";
            Console.WriteLine(rowToPrint);
            stars -= 2;
            dashes++;
        }
    }
}