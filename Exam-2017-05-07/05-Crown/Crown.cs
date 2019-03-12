using System;

class Crown
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        string rowToPrint = $"@{new string(' ', size - 2)}@{new string(' ', size - 2)}@";

        Console.WriteLine(rowToPrint);
        rowToPrint = $"**{new string(' ', size - 3)}*{new string(' ', size - 3)}**";
        Console.WriteLine(rowToPrint);

        int leftRightDots = 1;
        int spaces = size - 5;
        int middleDots = 1;

        for (int row = 0; row < size / 2 - 2; row++)
        {
            rowToPrint = $"*{new string('.', leftRightDots)}*{new string(' ', spaces)}*{new string('.', middleDots)}*{new string(' ', spaces)}*{new string('.', leftRightDots)}*";
            Console.WriteLine(rowToPrint);
            leftRightDots++;
            spaces -= 2;
            middleDots += 2;
        }

        rowToPrint = $"*{new string('.', size / 2 - 1)}*{new string('.', size - 3)}*{new string('.', size / 2 - 1)}*"; 
        Console.WriteLine(rowToPrint);
        rowToPrint = $"*{new string('.', size / 2)}{new string('*', (size - 4) / 2)}.{new string('*', (size - 4) / 2)}{new string('.', size / 2)}*";
        Console.WriteLine(rowToPrint);
        rowToPrint = new string('*', 2 * size - 1);

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(rowToPrint);
        }
    }
}