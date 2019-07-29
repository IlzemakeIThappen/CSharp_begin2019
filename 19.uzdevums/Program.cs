using System;

namespace _19.uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ir dots int tipa masīvs ar sākotnējām vērtībām 4, 68, 7, 12, 56, 33, 1, 90, 4.
            //    Ir jāatrod visas vērtības, kuras lielākas par 15 un jāievieto jaunā int tipa masīvā, 
            //kura saturs ir jāizvada uz ekrāna.
            int[] numbers = new [] {4, 68, 7, 12, 56, 33, 1, 90, 4};
            int izvade;
            int izvade2;
            for (int i = 0; i < numbers.Length; i++)
            {
                
                izvade = numbers[i];
                if (izvade>15)
                {
                    
                    int[] numbers2 = new[] { izvade };
                    for (int k = 0; k < numbers2.Length; k++)
                    {
                        izvade2 = numbers2[k];
                        Console.WriteLine(izvade2);
                    }
                }
            }       
          
        }
    }
}
