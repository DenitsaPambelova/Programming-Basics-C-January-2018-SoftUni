using System;

class Ladybird
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < (size * 2 + 1 - 5) / 2; i++)
        {
            Console.Write(" ");
        }

        Console.WriteLine("@   @");

        for (int row = 0; row < 3; row++)
        {
            for (int j = 0; j < (size * 2 + 1 - 3) / 2; j++)
            {
                Console.Write(" ");
            }

            switch (row)
            {
                case 0:
                    Console.WriteLine("\\_/");
                    break;
                case 1:
                    Console.WriteLine("/ \\");
                    break;
                case 2:
                    Console.WriteLine("|_|");
                    break;
            }
        }

        for (int row = size; row > 0; row--)
        {
            for (int j = row - 1; j > 0; j--)
            {
                Console.Write(" ");
            }

            Console.Write("/");

            for (int j = row; j < size; j++)
            {
                Console.Write(" ");
            }

            Console.Write("|");

            for (int j = row; j < size; j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine("\\");
        }

        for (int row = 0; row < size / 2; row++)
        {
            Console.Write("|");

            for (int j = 0; j < (size - 2) / 2; j++)
            {
                Console.Write(" ");
            }

            Console.Write("@");

            for (int j = 0; j < (size - 1) / 2; j++)
            {
                Console.Write(" ");
            }

            Console.Write("|");

            for (int j = 0; j < (size - 1) / 2; j++)
            {
                Console.Write(" ");
            }

            Console.Write("@");

            for (int j = 0; j < (size - 2) / 2; j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine("|");
        }

        var a = 0;

        for (int row = size - 1; row > 0; row -= 2)
        {
            for (int j = row; j < size - 1; j += 2)
            {
                Console.Write(" ");
            }

            Console.Write("\\");

            for (int j = row + a; j > 0; j--)
            {
                Console.Write(" ");
            }

            Console.Write("|");

            for (int j = row + a; j > 0; j--)
            {
                Console.Write(" ");
            }

            Console.WriteLine("/");
            a++;
        }

        for (int i = 0; i < size - size / 2; i++)
        {
            Console.Write(" ");
        }

        for (int i = 0; i < size / 2; i++)
        {
            Console.Write("^");
        }

        Console.Write("|");

        for (int i = 0; i < size / 2; i++)
        {
            Console.Write("^");
        }

        Console.WriteLine();
    }
}