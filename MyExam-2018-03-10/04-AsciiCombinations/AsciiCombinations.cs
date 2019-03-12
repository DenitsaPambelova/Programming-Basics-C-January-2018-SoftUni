using System;

class AsciiCombinations
{
    static void Main(string[] args)
    {
        int sybolsCount = int.Parse(Console.ReadLine());
        string numbers = "";
        string lowers = "";
        string uppers = "";
        string symbols = "";
        int numbersSum = 0;
        int lowersSum = 0;
        int uppersSum = 0;
        int symbolsSum = 0;


        for (int currentSymbol = 0; currentSymbol < sybolsCount; currentSymbol++)
        {
            char symbol = char.Parse(Console.ReadLine());

            if ('0' <= symbol && symbol <= '9')
            {
                numbers += symbol;
                numbersSum += symbol;
            }
            else if ('a' <= symbol && symbol <= 'z')
            {
                lowers += symbol;
                lowersSum += symbol;
            }
            else if ('A' <= symbol && symbol <= 'Z')
            {
                uppers += symbol;
                uppersSum += symbol;
            }
            else
            {
                symbols += symbol;
                symbolsSum += symbol;
            }
        }

        if (numbersSum >= lowersSum && numbersSum >= uppersSum && numbersSum >= symbolsSum)
        {
            Console.WriteLine($"Biggest ASCII sum is:{numbersSum}");
            Console.WriteLine($"Combination of characters is:{numbers}");
        }
        else if (uppersSum >= numbersSum && uppersSum >= lowersSum && uppersSum >= symbolsSum)
        {
            Console.WriteLine($"Biggest ASCII sum is:{uppersSum}");
            Console.WriteLine($"Combination of characters is:{uppers}");
        }
        else if (lowersSum >= numbersSum && lowersSum >= uppersSum && lowersSum >= symbolsSum)
        {
            Console.WriteLine($"Biggest ASCII sum is:{lowersSum}");
            Console.WriteLine($"Combination of characters is:{lowers}");
        }
        else
        {
            Console.WriteLine($"Biggest ASCII sum is:{symbolsSum}");
            Console.WriteLine($"Combination of characters is:{symbols}");
        }
    }
}