using System;

class Battles
{
    static void Main(string[] args)
    {
        int playerOne = int.Parse(Console.ReadLine());
        int playerTwo = int.Parse(Console.ReadLine());
        int maxBattles = int.Parse(Console.ReadLine());

        int battlesPlayed = 0;

        for (int i = 1; i <= playerOne; i++)
        {
            for (int j = 1; j <= playerTwo; j++)
            {
                if (battlesPlayed < maxBattles)
                {
                    Console.Write($"({i} <-> {j}) ");
                    battlesPlayed++;
                }
                else
                {
                    break;
                }
            }
        }
    }
}