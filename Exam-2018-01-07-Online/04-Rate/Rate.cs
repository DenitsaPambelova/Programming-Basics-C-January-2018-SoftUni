using System;

class Rate
{
    static void Main(string[] args)
    {
        double sum = double.Parse(Console.ReadLine());
        int months = int.Parse(Console.ReadLine());
        double simpleTotal = sum;
        double complexTotal = sum;

        for (int i = 0; i < months; i++)
        {
            simpleTotal += 0.03 * sum;
            complexTotal *= 1.027;
        }

        Console.WriteLine($"Simple interest rate: {simpleTotal:F2} lv.");
        Console.WriteLine($"Complex interest rate: {complexTotal:F2} lv.");

        if (simpleTotal > complexTotal)
        {
            Console.WriteLine($"Choose a simple interest rate. You will win {(simpleTotal - complexTotal):F2} lv.");
        }
        else
        {
            Console.WriteLine($"Choose a complex interest rate. You will win {(complexTotal - simpleTotal):F2} lv.");
        }
    }
}