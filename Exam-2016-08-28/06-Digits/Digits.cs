using System;

class Digits
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number / 100;
        int secondDigit = number % 100 / 10;
        int thirdDigit = number % 10;
        int rows = firstDigit + secondDigit;
        int columns = firstDigit + thirdDigit;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                if (number % 5 == 0)
                {
                    number -= firstDigit;
                }
                else if (number % 3 == 0)
                {
                    number -= secondDigit;
                }
                else
                {
                    number += thirdDigit;
                }

                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
    }
}