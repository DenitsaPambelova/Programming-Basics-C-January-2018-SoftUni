using System;

class TileFixing
{
    static void Main(string[] args)
    {
        int areaSide = int.Parse(Console.ReadLine());
        double tileWidth = double.Parse(Console.ReadLine());
        double tileLenght = double.Parse(Console.ReadLine());
        int benchWidth = int.Parse(Console.ReadLine());
        int benchLength = int.Parse(Console.ReadLine());

        int area = areaSide * areaSide - benchWidth * benchLength;
        double tileArea = tileWidth * tileLenght;
        double tilesCount = area / tileArea;
        double time = tilesCount * 0.2;

        Console.WriteLine($"{tilesCount:F2}");
        Console.WriteLine($"{time:F2}");
    }
}