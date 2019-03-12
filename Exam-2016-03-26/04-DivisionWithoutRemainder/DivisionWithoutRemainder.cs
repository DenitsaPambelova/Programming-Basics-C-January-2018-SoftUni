using System;

class DivisionWithoutRemainder
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        double p1 = 0;
        double p2 = 0;
        double p3 = 0;

        for (int num = 0; num < count; num++)
        {
            var number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                p1++;
            }
            if (number % 3 == 0)
            {
                p2++;
            }
            if (number % 4 == 0)
            {
                p3++;
            }
        }

        Console.WriteLine($"{p1 / count * 100:F2}%");
        Console.WriteLine($"{p2 / count * 100:F2}%");
        Console.WriteLine($"{p3 / count * 100:F2}%");
    }
}