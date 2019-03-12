using System;

class StupidPaswordGenerator
{
    static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        for (int symbolOne = 1; symbolOne <= firstNum; symbolOne++)
        {
            for (int symbolTwo = 1; symbolTwo <= firstNum; symbolTwo++)
            {
                for (char symbolThree = 'a'; symbolThree < 'a' + secondNum; symbolThree++)
                {
                    for (char symbolFour = 'a'; symbolFour < 'a' + secondNum; symbolFour++)
                    {
                        for (int symbolFive = 1; symbolFive <= firstNum; symbolFive++)
                        {
                            if (symbolFive > symbolOne && symbolFive > symbolTwo)
                            {
                                Console.Write($"{symbolOne}{symbolTwo}{symbolThree}{symbolFour}{symbolFive} ");
                            }
                        }
                    }
                }
            }
        }
    }
}