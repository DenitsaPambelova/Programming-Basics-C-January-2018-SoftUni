using System;

class StopNumber
{
    static void Main(string[] args)
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());
        int stopNumber = int.Parse(Console.ReadLine());

        for (int currentNumber = endNumber; currentNumber >= startNumber; currentNumber--)
        {
            if (currentNumber % 2 == 0 && currentNumber % 3 == 0)
            {
                if (currentNumber == stopNumber)
                {
                    break;
                }
                Console.Write($"{currentNumber} ");
            }
        }
    }
}