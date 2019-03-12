using System;

class Histogram
{
    static void Main(string[] args)
    {
        var count = int.Parse(Console.ReadLine());

        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        int p4 = 0;
        int p5 = 0;

        for (int i = 0; i < count; i++)
        {
            var number = int.Parse(Console.ReadLine());

            if (number < 200)
            {
                p1++;
            }
            else if (number < 400)
            {
                p2++;
            }
            else if (number < 600)
            {
                p3++;
            }
            else if (number < 800)
            {
                p4++;
            }
            else
            {
                p5++;
            }
        }

        Console.WriteLine($"{1.0 * p1 / count * 100:F2}");
        Console.WriteLine($"{1.0 * p2 / count * 100:F2}");
        Console.WriteLine($"{1.0 * p3 / count * 100:F2}");
        Console.WriteLine($"{1.0 * p4 / count * 100:F2}");
        Console.WriteLine($"{1.0 * p5 / count * 100:F2}");
    }
}