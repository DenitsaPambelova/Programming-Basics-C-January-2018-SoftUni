using System;

class TwoNumbersSum
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int magic = int.Parse(Console.ReadLine());

        int count = 0;
        int number = 0;

        for (int i = start; i >= end; i--)
        {
            for (int j = start; j >= end; j--)
            {
                count++;

                if (i + j == magic)
                {
                    number = count;
                    Console.WriteLine($"Combination N:{number} ({i} + {j} = {magic})");
                    j = end - 1;
                    i = end - 1;
                }
            }
        }

        if (number == 0)
        {
            Console.WriteLine($"{count} combinations - neither equals {magic}");
        }
    }
}