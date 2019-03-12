using System;

class ChristmasSock
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        string rowToPrint = "";
        int dashes = size - 1;
        int middle = 2;

        for (int row = 0; row < 3; row++)
        {
            if (row == 1)
            {
                rowToPrint = $"|{new string('*', 2 * size)}|";
            }
            else
            {
                rowToPrint = $"|{new string('-', 2 * size)}|";
            }
            Console.WriteLine(rowToPrint);
        }

        for (int row = 0; row < size - 1; row++)
        {
            rowToPrint = $"|{new string('-', dashes)}{new string('~', middle)}{new string('-', dashes)}|";
            Console.WriteLine(rowToPrint);
            dashes--;
            middle += 2;
        }

        dashes += 2;
        middle -= 4;

        for (int row = 0; row < size - 2; row++)
        {
            rowToPrint = $"|{new string('-', dashes)}{new string('~', middle)}{new string('-', dashes)}|";
            Console.WriteLine(rowToPrint);
            dashes++;
            middle -= 2;
        }


        for (int row = 0; row < size + 3; row++)
        {

            for (int col = 0; col < row; col++)
            {
                Console.Write("-");
            }
            Console.Write("\\");

            if (row == size / 2 || row == size / 2 + 2)
            {
                for (int col = 0; col < (2 * size + 1 - 5) / 2; col++)
                {
                    Console.Write(".");
                }
                if (row == size / 2)
                {
                    Console.Write("MERRY");
                }
                else
                {
                    Console.Write("X-MAS");
                }
                for (int col = 0; col < (2 * size + 1 - 5) / 2; col++)
                {
                    Console.Write(".");
                }
            }
            else if (row == size + 2)
            {
                for (int col = 0; col < 2 * size + 1; col++)
                {
                    Console.Write("_");
                }
            }
            else
            {
                for (int col = 0; col < 2 * size + 1; col++)
                {
                    Console.Write(".");
                }
            }
            if (row == size + 2)
            {
                Console.WriteLine(")");
            }
            else
            {
                Console.WriteLine("\\");
            }
        }
    }
}