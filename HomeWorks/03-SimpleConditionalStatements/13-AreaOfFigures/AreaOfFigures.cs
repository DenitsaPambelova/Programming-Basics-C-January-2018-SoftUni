using System;

class AreaOfFigures
{
    static void Main(string[] args)
    {
        string figure = Console.ReadLine();

        double area = 0;

        switch (figure)
        {
            case "square":
                double squareSide = double.Parse(Console.ReadLine());
                area = squareSide * squareSide;
                break;
            case "rectangle":
                double rectangleLenght = double.Parse(Console.ReadLine());
                double rectangleWidth = double.Parse(Console.ReadLine());
                area = rectangleLenght * rectangleWidth;
                break;
            case "circle":
                double circleRadius = double.Parse(Console.ReadLine());
                area = circleRadius * circleRadius * Math.PI;
                break;
            case "triangle":
                double triangleSide = double.Parse(Console.ReadLine());
                double triangleheight = double.Parse(Console.ReadLine());
                area = triangleheight * triangleSide / 2;
                break;
        }

        Console.WriteLine($"{area:F3}");
    }
}