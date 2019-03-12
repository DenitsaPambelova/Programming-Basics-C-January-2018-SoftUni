using System;

class Triangle
{
    static void Main(string[] args)
    {
        decimal sideA = decimal.Parse(Console.ReadLine());
        decimal sideB = decimal.Parse(Console.ReadLine());
        decimal sideC = decimal.Parse(Console.ReadLine());

        if (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB)
        {
            if (sideA == sideB && sideB == sideC)
            {
                Console.WriteLine($"Triangle with sides {sideA.ToString("G29")}, {sideB.ToString("G29")} and {sideC.ToString("G29")} is equilateral.");
            }
            else if (sideA != sideB && sideA != sideC && sideB != sideC)
            {
                Console.WriteLine($"Triangle with sides {sideA.ToString("G29")}, {sideB.ToString("G29")} and {sideC.ToString("G29")} is scalene.");
            }
            else
            {
                Console.WriteLine($"Triangle with sides {sideA.ToString("G29")}, {sideB.ToString("G29")} and {sideC.ToString("G29")} is isosceles.");
            }
        }
        else
        {
            Console.WriteLine($"There is no triangle with sides {sideA.ToString("G29")}, {sideB.ToString("G29")} and {sideC.ToString("G29")}.");
        }
    }
}