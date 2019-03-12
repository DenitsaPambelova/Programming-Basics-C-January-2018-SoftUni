using System;

class MaxCombination
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int count = int.Parse(Console.ReadLine());

        int tempCount = 0;

        for (int digit1 = start; digit1 <= end; digit1++)
        {
            for (int digit2 = start; digit2 <= end; digit2++)
            {
                if (tempCount < count)
                {
                    Console.Write($"<{digit1}-{digit2}>");
                    tempCount++;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
