using System;

namespace _10.uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveodot console aplikāciju, kurā ir int masīvs ar vērtībām 7, 4, 7, 3, 6, 9, 2.
            //    Samainīt elementu, kura sākotnējā vērtība ir 3 uz 10.

            int[] numbers = new[] { 7, 4, 7, 3, 6, 9, 2 };
            int izvade;
            for (int i = 0; i < numbers.Length; i++)
            {
                izvade = numbers[i];

                if (i == 3) {
                    izvade = 10;
                }
                
                Console.WriteLine(izvade);
            }
          
        }
    }
}
