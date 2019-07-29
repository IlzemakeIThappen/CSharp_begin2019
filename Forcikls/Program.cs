using System;

namespace Forcikls
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarēt int[] -masīvu int[] numbers = { 1, 3, 4, 8, 0, 23 };
            //Izdrukāt uz ekrāna visas masīva elementu vērtības un pēc tam tikai tās vērtības, kuras lielākas par 5.

            int [] numbers = new [] { 1, 3, 4, 8, 0, 23 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>5)
                {
                    Console.WriteLine($" Par 5 lielāki ir : {numbers[i]}");
                }
            }
        }
    }
}
