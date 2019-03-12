using System;

class MultiplyTable
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int firstDigit = (number % 100) % 10;
        int thirdDigit = number / 100;

        while (number >= 100)
        {
            number /= 10;
        }

        int secondDigit = number % 10;

        for (int num1 = 1; num1 <= firstDigit; num1++)
        {
            for (int num2 = 1; num2 <= secondDigit; num2++)
            {
                for (int num3 = 1; num3 <= thirdDigit; num3++)
                {
                    Console.WriteLine($"{num1} * {num2} * {num3} = {num1 * num2 * num3};");
                }
            }
        }
    }
}