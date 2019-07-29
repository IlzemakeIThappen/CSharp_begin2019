using System;

namespace _17.uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            //           Definēt int masīvu ar 10 elementiem { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8 }.
            //Drukājam vērtības console logā, tik ilgi kamēr sastopam vērtību 22.
            //Pēc vērtības 22 sasniegšanas cikls ir jāpārtrauc.

            int[] numbers = new[] { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8 };
            
         
            foreach (var number in numbers)
            {
                Console.WriteLine( number);
                if (number==22)
                {
                    break;
                }
            }

         }
    }
}
