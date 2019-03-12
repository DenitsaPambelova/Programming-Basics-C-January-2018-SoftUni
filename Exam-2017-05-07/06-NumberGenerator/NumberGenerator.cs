using System;

class NumberGenerator
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int specialNumber = int.Parse(Console.ReadLine());
        int controlNumber = int.Parse(Console.ReadLine());

        for (int digit1 = firstNumber; digit1 >= 1; digit1--)
        {
            for (int digit2 = secondNumber; digit2 >= 1; digit2--)
            {
                for (int digit3 = thirdNumber; digit3 >= 1; digit3--)
                {
                    int number = digit1 * 100 + digit2 * 10 + digit3;

                    if (number % 3 == 0)
                    {
                        specialNumber += 5;
                    }
                    else if (digit3 == 5)
                    {
                        specialNumber -= 2;
                    }
                    else if (number % 2 == 0)
                    {
                        specialNumber *= 2;
                    }

                    if (controlNumber <= specialNumber)
                    {
                        digit3 = 0;
                        digit2 = 0;
                        digit1 = 0;
                    }
                }
            }
        }

        string output = $"No! {specialNumber} is the last reached special number.";

        if (controlNumber <= specialNumber)
        {
            output = $"Yes! Control number was reached! Current special number is {specialNumber}.";
        }

        Console.WriteLine(output);
    }
}