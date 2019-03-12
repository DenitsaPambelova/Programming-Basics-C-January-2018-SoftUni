using System;

class PrimePairs
{
    static void Main(string[] args)
    {
        int firstPair = int.Parse(Console.ReadLine());
        int secondPair = int.Parse(Console.ReadLine());
        int firstDifference = int.Parse(Console.ReadLine());
        int secondDifference = int.Parse(Console.ReadLine());

        for (int firstNumber = firstPair; firstNumber <= firstPair + firstDifference; firstNumber++)
        {
            for (int secondNumber = secondPair; secondNumber <= secondPair + secondDifference; secondNumber++)
            {
                if (IsPrime(firstNumber) && IsPrime(secondNumber))
                {
                    Console.WriteLine($"{firstNumber}{secondNumber}");
                }
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }
}