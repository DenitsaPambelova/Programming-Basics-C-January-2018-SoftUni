using System;

class Rocket
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int outside = (3 * size - 2) / 2;
        int inside = 0;
        string rowToPrint = "";

        for (int row = 0; row < size; row++)
        {
            rowToPrint = $"{new string('.', outside)}/{new string(' ', inside)}\\{new string('.', outside)}";
            Console.WriteLine(rowToPrint);
            outside--;
            inside += 2;
        }

        outside++;
        rowToPrint = $"{new string('.', outside)}{new string('*', inside)}{new string('.', outside)}";
        Console.WriteLine(rowToPrint);
        inside -= 2;
        
        for (int row = 0; row < 2 * size; row++)
        {
            rowToPrint = $"{new string('.', outside)}|{new string('\\', inside)}|{new string('.', outside)}";
            Console.WriteLine(rowToPrint);
        }

        for (int i = 0; i < size / 2; i++)
        {
            rowToPrint = $"{new string('.', outside)}/{new string('*', inside)}\\{new string('.', outside)}";
            Console.WriteLine(rowToPrint);
            outside--;
            inside += 2;
        }
    }
}