using System;

class ControlNumber
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int controlNumber = int.Parse(Console.ReadLine());

        int sum = 0;
        int count = 0;

        for (int i = 1; i <= firstNumber; i++)
        {
            for (int j = secondNumber; j >= 1; j--)
            {
                if (sum <= controlNumber)
                {
                    sum += i * 2 + j * 3;
                    count++;
                }
            }
        }

        if (sum >= controlNumber)
        {
            Console.WriteLine($"{count} moves");
            Console.WriteLine($"Score: {sum} >= {controlNumber}");
        }
        else
        {
            Console.WriteLine($"{count} moves");
        }
    }
}