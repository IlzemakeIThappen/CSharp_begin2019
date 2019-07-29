using System;

namespace _22.UZDEVUMS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot divdimensiju masīvu int[5, 5] un piešķirt elementiem vērtības.Izdrukāt visu elementu vērtības console.
            int[,] numbers = new[,] { { 1, 9 },{ 3, 5 }, { 2, 11 }, { 79, 33 }, { 5, 22 } };
            
            int num1 = numbers.GetUpperBound(0);
            int num2 = numbers.GetUpperBound(1);
    
            for (int i = 0; i <= num1; i++)
            {
                for (int x = 0; x <= num2; x++)
                {
                   Console.WriteLine(numbers[i, x]);
                }
                Console.WriteLine();
            }
        }

    }

}
   