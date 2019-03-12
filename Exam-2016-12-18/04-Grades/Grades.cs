using System;

class Grades
{
    static void Main(string[] args)
    {
        int students = int.Parse(Console.ReadLine());

        int excellent = 0;
        int good = 0;
        int middle = 0;
        int fail = 0;
        double all = 0;

        for (int i = 0; i < students; i++)
        {
            double grade = double.Parse(Console.ReadLine());

            all += grade;

            if (grade >= 5)
            {
                excellent++;
            }
            else if (grade >= 4)
            {
                good++;
            }
            else if (grade >= 3)
            {
                middle++;
            }
            else
            {
                fail++;
            }
        }

        double average = all / students;

        Console.WriteLine($"Top students: {1.0 * excellent / students * 100:F2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {1.0 * good / students * 100:F2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {1.0 * middle / students * 100:F2}%");
        Console.WriteLine($"Fail: {1.0 * fail / students * 100:F2}%");
        Console.WriteLine($"Average: {average:F2}");
    }
}