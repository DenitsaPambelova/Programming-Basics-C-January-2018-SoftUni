using System;

class Sword
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        Console.WriteLine($"{new string('#', size - 1)}/^\\{new string('#', size - 1)}");

        int hashtags = size - 2;
        int spaces = 3;
        int rows = 0;

        for (int row = 0; row < size / 2; row++)
        {
            Console.WriteLine($"{new string('#', hashtags)}.{new string(' ', spaces)}.{new string('#', hashtags)}");
            hashtags--;
            spaces += 2;
        }

        if (size % 2 == 0)
        {
            spaces = size + 1;
        }
        else
        {
            spaces = size;
        }

        hashtags++;

        if (size <= 5)
        {
            rows = 1;
        }
        else
        {
            rows = size - 4;
        }

        Console.WriteLine($"{new string('#', hashtags)}|{new string(' ', size / 2)}S{new string(' ', size / 2)}|{new string('#', hashtags)}");
        Console.WriteLine($"{new string('#', hashtags)}|{new string(' ', size / 2)}O{new string(' ', size / 2)}|{new string('#', hashtags)}");
        Console.WriteLine($"{new string('#', hashtags)}|{new string(' ', size / 2)}F{new string(' ', size / 2)}|{new string('#', hashtags)}");
        Console.WriteLine($"{new string('#', hashtags)}|{new string(' ', size / 2)}T{new string(' ', size / 2)}|{new string('#', hashtags)}");

        for (int row = 0; row < rows; row++)
        {
            Console.WriteLine($"{new string('#', hashtags)}|{new string(' ', spaces)}|{new string('#', hashtags)}");
        }

        Console.WriteLine($"{new string('#', hashtags)}|{new string(' ', size / 2)}U{new string(' ', size / 2)}|{new string('#', hashtags)}");
        Console.WriteLine($"{new string('#', hashtags)}|{new string(' ', size / 2)}N{new string(' ', size / 2)}|{new string('#', hashtags)}");
        Console.WriteLine($"{new string('#', hashtags)}|{new string(' ', size / 2)}I{new string(' ', size / 2)}|{new string('#', hashtags)}");
        Console.WriteLine($"@{new string('=', size * 2 - 1)}@");

        for (int row = 0; row < size / 2; row++)
        {
            Console.WriteLine($"{new string('#', hashtags + 2)}|{new string(' ', spaces - 4)}|{new string('#', hashtags + 2)}");
        }

        Console.WriteLine($"{new string('#', hashtags + 2)}\\{new string('.', spaces - 4)}/{new string('#', hashtags + 2)}");

    }
}