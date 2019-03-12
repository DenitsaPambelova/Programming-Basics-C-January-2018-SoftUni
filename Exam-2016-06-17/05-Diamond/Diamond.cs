using System;

class Diamond
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int outside = size;
        int inside = 3 * size;
        string rowToPrint = $"{new string('.', outside)}{new string('*', inside)}{new string('.', outside)}";

        Console.WriteLine(rowToPrint);
        outside--;

        for (int row = 0; row < size - 1; row++)
        {
            rowToPrint = $"{new string('.', outside)}*{new string('.', inside)}*{new string('.', outside)}";
            Console.WriteLine(rowToPrint);
            outside--;
            inside += 2;
        }

        outside++;
        inside -= 2;
        rowToPrint = new string('*', size * 5);
        Console.WriteLine(rowToPrint);

        for (int row = 0; row < 2 * size; row++)
        {
            rowToPrint = $"{new string('.', outside)}*{new string('.', inside)}*{new string('.', outside)}";
            Console.WriteLine(rowToPrint);
            outside++;
            inside -= 2;
        }

        inside += 2;
        rowToPrint = $"{new string('.', outside)}{new string('*', inside)}{new string('.', outside)}";
        Console.WriteLine(rowToPrint);
    }
}