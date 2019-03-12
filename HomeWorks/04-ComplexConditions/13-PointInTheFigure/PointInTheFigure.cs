using System;

class PointInTheFigure
{
    static void Main(string[] args)
    {
        int squareSide = int.Parse(Console.ReadLine());
        int pointX = int.Parse(Console.ReadLine());
        int pointY = int.Parse(Console.ReadLine());

        bool border = ((pointX == 0 || pointX == 3 * squareSide) && pointY <= squareSide && pointY >= 0) ||
                      (pointY == 0 && pointX <= 3 * squareSide && pointX >= 0) ||
                      (pointY == squareSide && (pointX <= squareSide && pointX >= 0 || pointX >= 2 * squareSide && pointX <= 3 * squareSide)) ||
                      (pointY == 4 * squareSide && pointX >= squareSide && pointX <= 2 * squareSide) ||
                      ((pointX == squareSide || pointX == 2 * squareSide) && pointY >= squareSide && pointY <= 4 * squareSide);
        bool inside = (pointX > 0 && pointX < 3 * squareSide && pointY > 0 && pointY < squareSide) ||
                      (pointX > squareSide && pointX < 2 * squareSide && pointY > squareSide && pointY < 4 * squareSide) ||
                      (pointX > squareSide && pointX < 2 * squareSide && pointY == squareSide);

        if (border)
        {
            Console.WriteLine("border");
        }
        else if (inside)
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }
    }
}