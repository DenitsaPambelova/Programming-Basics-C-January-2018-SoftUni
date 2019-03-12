using System;

class OwnBussines
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int heigth = int.Parse(Console.ReadLine());
        int space = width * length * heigth;
        int moreSpaceNeeded = 0;

        string command;

        while ((command = Console.ReadLine()) != "Done")
        {
            int computers = int.Parse(command);

            if (space >= computers)
            {
                space -= computers;
                continue;
            }

            moreSpaceNeeded = computers - space;
            break;
        }

        if (moreSpaceNeeded == 0)
        {
            Console.WriteLine($"{space} Cubic meters left.");
        }
        else
        {
            Console.WriteLine($"No more free space! You need {moreSpaceNeeded} Cubic meters more.");
        }
    }
}