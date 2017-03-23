using System;
    class Task5
    {
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < 2 * n; i++)
        {
            Console.WriteLine(new string('.', (12 * n - 5) / 2 - 3 * i) + new string('#', 1 + 6 * i) + new string('.', (12 * n - 5) / 2 - 3 * i));
        }

       
        for (int i = 0; i < (4 * n - 2) - 2 * n - n; i++)
        {
            Console.WriteLine("|" + new string('.', 2 + 3 * i) + new string('#', (12 * n - 5) - 6 - 6 * i) + new string('.', 3 + 3 * i));
        }

        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("|" + new string('.',((12*n-5)-(6*n+2))/2) + new string('#',6*n+1) 
                + new string('.', ((12 * n - 5) - (6 * n + 2)) / 2) +".");
        }

        Console.WriteLine("@" + new string('.', ((12 * n - 5) - (6 * n + 2)) / 2) + new string('#', 6 * n + 1)
               + new string('.', ((12 * n - 5) - (6 * n + 2)) / 2)+ ".");

    }
    }

