using System;

class Butterfly
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int a = 2;

        for (int i = size - 2; i > 0; i--)
        {
            for (int j = i; j <= size - 2; j++)
            {
                Console.Write("*\\");
            }

            for (int j = 0; j < 4 * size - 4 - 2 * a; j++)
            {
                Console.Write(" ");
            }

            for (int j = i; j <= size - 2; j++)
            {
                Console.Write("/*");
            }

            a += 2;
            Console.WriteLine();
        }

        for (int i = 0; i < 2 * size - 2; i++)
        {
            Console.Write("\\/");
        }

        Console.WriteLine();

        for (int i = 0; i < size / 2; i++)
        {
            for (int j = 0; j < 2 * size - 5; j++)
            {
                Console.Write("<");
            }

            Console.Write("*|**|*");

            for (int j = 0; j < 2 * size - 5; j++)
            {
                Console.Write(">");
            }

            Console.WriteLine();
        }

        for (int i = 0; i < 2 * size - 2; i++)
        {
            Console.Write("/\\");
        }

        Console.WriteLine();
        var b = 4;

        for (int i = 0; i < size - 2; i++)
        {
            for (int j = i; j < size - 2; j++)
            {
                Console.Write("*/");
            }
            for (int j = 0; j < b; j++)
            {
                Console.Write(" ");
            }
            for (int j = i; j < size - 2; j++)
            {
                Console.Write("\\*");
            }

            b += 4;
            Console.WriteLine();
        }
    }
}