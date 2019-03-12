using System;

class Stop
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int dots = size + 1;
        int dashes = 2 * size + 1;
        string row = $"{new string('.', dots)}{new string('-', dashes)}{new string('.', dots)}";

        Console.WriteLine(row);
        dots--;
        dashes -= 2;

        for (int rowNumber = 0; rowNumber < size; rowNumber++)
        {
            row = $"{new string('.', dots)}//{new string('_', dashes)}\\\\{new string('.', dots)}";
            Console.WriteLine(row);
            dots--;
            dashes += 2;
        }

        var middle = 2 * size - 3;

        row = $"//{new string('_', middle)}STOP!{new string('_', middle)}\\\\";
        Console.WriteLine(row);
        
        for (int i = 0; i < size; i++)
        {
            row = $"{new string('.', dots)}\\\\{new string('_', dashes)}//{new string('.', dots)}";
            Console.WriteLine(row);
            dots++;
            dashes -= 2;
        }
    }
}