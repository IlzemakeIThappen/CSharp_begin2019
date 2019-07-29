using System;

namespace _9.uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Izveidot console aplikāciju, kurā ir definēts int masīvs ar vērtībām 100, 200, 233, 66, 77, 98.
            //Izdrukāt uz ekrāna pirmā un pēdējā elementa vērtības.
            int[] numbers = new[] { 100, 200, 233, 66, 77, 98 };

          
            Console.WriteLine($"Pirmais masīva cipars ir :  {numbers[0]}");

            int lastnumber = numbers[numbers.Length - 1];
            Console.WriteLine($"Pēdējais masīva cipars ir :  {lastnumber}");
          
        }

    }
    
}
