using System;

    class Task4
    {
        static void Main()
        {
        int countGames = int.Parse(Console.ReadLine());

        double totalScore = 0 ;
        double counter09 = 0;
        double counter1019 = 0;
        double counter2029 = 0;
        double counter3039 = 0;
        double counter4050 = 0;
        double counterInvalid = 0;
        
        for (int i = 0; i < countGames; i++)
        {
            double currentNumber = double.Parse(Console.ReadLine());

            if (currentNumber >= 0 && currentNumber<=9 )
            {
                counter09 ++;
                
                totalScore = totalScore + currentNumber*0.2;
            }
            else if (currentNumber >= 10 && currentNumber <= 19)
            {
                counter1019++;
                
                totalScore = totalScore + currentNumber * 0.3;
            }
            else if (currentNumber >= 20 && currentNumber <= 29)
            {
                counter2029++;
                
                totalScore = totalScore + currentNumber * 0.4;
            }
            else if (currentNumber >= 30 && currentNumber <= 39)
            {
                counter3039++;
                
                totalScore = totalScore + 50;
            }
            else if (currentNumber >= 40 && currentNumber <= 50)
            {
                counter4050++;
                
                totalScore = totalScore + 100;
            }
            else if (currentNumber<0||currentNumber>50)
            {
                counterInvalid++;
                
                totalScore =  totalScore / 2;
            }

        }
        Console.WriteLine($"{totalScore:f2}");

        Console.WriteLine($"From 0 to 9: {counter09 / countGames * 100:f2}%");
        Console.WriteLine($"From 10 to 19: {counter1019 / countGames * 100:f2}%");
        Console.WriteLine($"From 20 to 29: {counter2029 / countGames * 100:f2}%");
        Console.WriteLine($"From 30 to 39: {counter3039 / countGames * 100:f2}%");
        Console.WriteLine($"From 40 to 50: {counter4050 / countGames * 100:f2}%");
        Console.WriteLine($"Invalid numbers: {counterInvalid / countGames * 100:f2}%");

    }
    }

