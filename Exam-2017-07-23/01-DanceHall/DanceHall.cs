using System;

class DanceHall
{
    static void Main(string[] args)
    {
        double hallLength = double.Parse(Console.ReadLine());
        double hallWidth = double.Parse(Console.ReadLine());
        double wardrobeSide = double.Parse(Console.ReadLine());

        double fullArea = hallLength * 100 * hallWidth * 100;
        double closetArea = wardrobeSide * 100 * wardrobeSide * 100;
        double benchArea = fullArea / 10;
        double freeSpace = fullArea - closetArea - benchArea;
        int dancers = Convert.ToInt32(Math.Floor(freeSpace / (40 + 7000)));

        Console.WriteLine(dancers);
    }
}