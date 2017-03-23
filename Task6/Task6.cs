using System;
    class Task6
    {
        static void Main()
        {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        int counter = 0;
       

        for (int i = firstNumber; i <= secondNumber; i++)
        {
           
            for (int k = firstNumber; k <=secondNumber; k++)
            {

                counter++;
                if (i+k==magicNumber)
                {
                 
                    Console.Write("Combination N:{0} ",counter);
                    Console.WriteLine("({0} + {1} = {2})", i, k, magicNumber);
                    return;
                }
                
            }
               
            }
        Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
    }




    }
    

