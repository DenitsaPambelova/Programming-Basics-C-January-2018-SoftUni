using System;

class SquareOfStars
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        string topBottomRow = new string('*', count);
        string middleRows = $"*{new string(' ', count - 2)}*";

        Console.WriteLine(topBottomRow);

        for (int i = 1; i < count - 1; i++)
        {
            Console.WriteLine(middleRows);
        }

        Console.WriteLine(topBottomRow);
    }
}
