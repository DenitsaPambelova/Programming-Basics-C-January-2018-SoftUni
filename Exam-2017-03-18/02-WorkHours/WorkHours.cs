using System;

class WorkHours
{
    static void Main(string[] args)
    {
        int hoursNeeded = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());

        int hoursWorked = workers * days * 8;

        if (hoursWorked >= hoursNeeded)
        {
            Console.WriteLine($"{hoursWorked - hoursNeeded} hours left");
        }
        else
        {
            Console.WriteLine($"{hoursNeeded - hoursWorked} overtime");
            Console.WriteLine($"Penalties: {(hoursNeeded - hoursWorked) * days}");
        }
    }
}