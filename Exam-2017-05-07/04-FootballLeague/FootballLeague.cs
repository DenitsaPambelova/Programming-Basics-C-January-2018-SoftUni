using System;

class FootballLeague
{
    static void Main(string[] args)
    {
        int capacity = int.Parse(Console.ReadLine());
        int fens = int.Parse(Console.ReadLine());
        int sectorA = 0;
        int sectorB = 0;
        int sectorV = 0;
        int sectorG = 0;

        for (int fen = 0; fen < fens; fen++)
        {
            char sector = char.Parse(Console.ReadLine());

            switch (sector)
            {
                case 'A':
                    sectorA++;
                    break;
                case 'B':
                    sectorB++;
                    break;
                case 'V':
                    sectorV++;
                    break;
                case 'G':
                    sectorG++;
                    break;
            }
        }

        Console.WriteLine($"{1.0 * sectorA / fens * 100:F2}%");
        Console.WriteLine($"{1.0 * sectorB / fens * 100:F2}%");
        Console.WriteLine($"{1.0 * sectorV / fens * 100:F2}%");
        Console.WriteLine($"{1.0 * sectorG / fens * 100:F2}%");
        Console.WriteLine($"{1.0 * fens / capacity * 100:F2}%");
    }
}