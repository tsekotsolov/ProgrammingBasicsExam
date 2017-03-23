using System;

    class Task1
    {
        static void Main()
        {
        double a = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double sides = (a * a / 2) * 2; // dvete strani 
        double rearSide = ((a / 2) * (a / 2) + ((a / 2) * (h - a / 2))/2);
        double frontSide = rearSide - (a / 5 * a / 5);

        double roof = (a * a / 2) * 2;

        double greenPaint = (sides + rearSide + frontSide)/3;
        double redPaint = roof / 5;

        Console.WriteLine($"{greenPaint:f2}");
        Console.WriteLine($"{redPaint:f2}");
    }
    }

