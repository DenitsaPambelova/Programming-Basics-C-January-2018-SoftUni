using System;

class Cup
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int temp = size;
        string rowToPrint = "";

        for (int row = 0; row < size / 2; row++)
        {
            PrintRow(size, temp);
            temp++;
        }

        for (int row = 0; row < size / 2 + 1; row++)
        {
            rowToPrint = $"{new string('.', temp)}#{new string('.', 5 * size - 2 * temp - 2)}#{new string('.', temp)}";
            Console.WriteLine(rowToPrint);
            temp++;
        }

        temp--;
        PrintRow(size, temp);
        temp -= 2;

        for (int row = 0; row < size / 2; row++)
        {
            PrintRow(size, temp);
        }

        rowToPrint = $"{new string('.', (5 * size - 9) / 2)}D^A^N^C^E^{new string('.', (5 * size - 9) / 2)}";
        Console.WriteLine(rowToPrint);

        for (int row = 0; row < size / 2 + 1; row++)
        {
            PrintRow(size, temp);
        }
    }

    static void PrintRow(int size, int temp)
    {
        string rowToPrint = $"{new string('.', temp)}{new string('#', 5 * size - 2 * temp)}{new string('.', temp)}";
        Console.WriteLine(rowToPrint);
    }
}