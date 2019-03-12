using System;

class TriangleOf55Stars
{
    static void Main(string[] args)
    {
        for (int rowNumber = 1; rowNumber < 11; rowNumber++)
        {
            string row = new string('*', rowNumber);

            Console.WriteLine(row);
        }
    }
}