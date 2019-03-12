using System;

class PictureInTheWall
{
    static void Main(string[] args)
    {
        int holeWidth = int.Parse(Console.ReadLine());
        int holeLength = int.Parse(Console.ReadLine());
        int pictureSide = int.Parse(Console.ReadLine());
        int picturesCount = int.Parse(Console.ReadLine());

        int holeArea = holeWidth * holeLength;
        int picturesArea = pictureSide * pictureSide * picturesCount;
        string output = $"The pictures don't fit in the hole. Picture area is {picturesArea - holeArea} bigger than hole area.";

        if (holeArea >= picturesArea)
        {
            output = $"The pictures fit in the hole. Hole area is {holeArea - picturesArea} bigger than pictures area.";
        }

        Console.WriteLine(output);
    }
}