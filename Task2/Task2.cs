using System;

    class Task2
    {
        static void Main()
        {
        int hoursNeded = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int workingDays = int.Parse(Console.ReadLine());

        int workingHours = workers * workingDays * 8;

       int deltaHours = workingHours - hoursNeded;

        if (workingHours>=hoursNeded)
        {
            Console.WriteLine("{0} hours left",deltaHours);
        }
        else
        {
            Console.WriteLine("{0} overtime", Math.Abs(deltaHours));
            Console.WriteLine("Penalties: {0} ", Math.Abs(deltaHours)*workingDays);
        }
    }
    }

