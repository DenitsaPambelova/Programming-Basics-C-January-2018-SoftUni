using System;

class SoftUniCamp
{
    static void Main(string[] args)
    {
        int groupsCount = int.Parse(Console.ReadLine());

        int automobile = 0;
        int microbus = 0;
        int smallBus = 0;
        int bigBus = 0;
        int train = 0;
        double allStudents = 0;

        for (int group = 0; group < groupsCount; group++)
        {
            int students = int.Parse(Console.ReadLine());

            allStudents += students;

            if (students <= 5)
            {
                automobile += students;
            }
            else if (students <= 12)
            {
                microbus += students;
            }
            else if (students <= 25)
            {
                smallBus += students;
            }
            else if (students <= 40)
            {
                bigBus += students;
            }
            else
            {
                train += students;
            }
        }

        Console.WriteLine($"{automobile / allStudents * 100:F2}%");
        Console.WriteLine($"{microbus / allStudents * 100:F2}%");
        Console.WriteLine($"{smallBus / allStudents * 100:F2}%");
        Console.WriteLine($"{bigBus / allStudents * 100:F2}%");
        Console.WriteLine($"{train / allStudents * 100:F2}%");
    }
}