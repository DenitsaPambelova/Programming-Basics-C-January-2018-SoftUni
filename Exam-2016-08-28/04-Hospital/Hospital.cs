using System;

class Hospital
{
    static void Main(string[] args)
    {
        int period = int.Parse(Console.ReadLine());

        int examined = 0;
        int unexamined = 0;
        int doctors = 7;

        for (int day = 1; day <= period; day++)
        {
            var patients = int.Parse(Console.ReadLine());

            if (day % 3 == 0)
            {
                if (unexamined > examined)
                {
                    doctors++;
                }
            }

            if (patients <= doctors)
            {
                examined += patients;
            }
            else
            {
                examined += doctors;
                unexamined += patients - doctors;
            }
        }

        Console.WriteLine($"Treated patients: {examined}.");
        Console.WriteLine($"Untreated patients: {unexamined}.");
    }
}