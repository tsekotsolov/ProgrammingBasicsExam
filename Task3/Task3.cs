using System;
    class Task3
    {
        static void Main()
        {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();

        
        double price = 0.0;

        string carClass = " ";
        string carType = " ";

        if (budget<=100)
        {
            carClass = "Economy class";
            if (season=="summer")
            {
                price = budget * 0.35;
                carType = "Cabrio";
            }
            else
            {
                price = budget * 0.65;
                 carType = "Jeep";
            }

        }
        else if (budget > 100 && budget<=500)
        {
             carClass = "Compact class";
            if (season == "summer")
            {
                price = budget * 0.45;
                carType = "Cabrio";
            }
            else
            {
                price = budget * 0.80;
                 carType = "Jeep";
            }
        }
        else if (budget > 500)
        {
             carClass = "Luxury class";
             carType = "Jeep";
            price = budget * 0.90;
        }

        Console.WriteLine(carClass);
        Console.WriteLine($"{carType} - {price:f2}");
    }
    }

