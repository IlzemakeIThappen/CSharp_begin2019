using System;

namespace _13.uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Definēt int tipa masīvu, kurā būs 10 elementi.Izveidot for ciklu, 
            //        kurš aizpildīs šo masīvu ar skaitļiem.Masīvā ir jāieraksta for cikla mainīgā vērtība.
            int[] numbers = new[] { 1, 5, 2, 1, 4, 5, 6, 3, 6, 4 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
                
        }
    }
}
