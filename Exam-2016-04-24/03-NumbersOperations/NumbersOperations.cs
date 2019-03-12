using System;

class NumbersOperations
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        char operation = char.Parse(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.Write($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber} - ");

                if ((firstNumber + secondNumber) % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.WriteLine("odd");
                }

                break;
            case '-':
                Console.Write($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber} - ");

                if ((firstNumber - secondNumber) % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.WriteLine("odd");
                }

                break;
            case '*':
                Console.Write($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber} - ");

                if ((firstNumber * secondNumber) % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.WriteLine("odd");
                }

                break;
            case '/':
                if (secondNumber != 0)
                {
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {(double)firstNumber / secondNumber:F2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }

                break;
            case '%':
                if (secondNumber != 0)
                {
                    Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }

                break;
        }
    }
}