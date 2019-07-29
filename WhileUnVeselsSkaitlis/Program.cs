using System;

namespace WhileUnVeselsSkaitlis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uztaisīt console aplikāciju, kura lietotājam paprasa ievadīt veselu skaitli. 
            //    Ja nav ievadīts vesels skaitlis, paziņot par kļūdu un likt ievadīt atkārtoti.
            //    Ja ievadītā vērtība ir skaitlis, tad izvadīt to uz ekrāna.

            Console.WriteLine("Lūdzu, ievadiet veselu skaitli:  ");
            var userinput = Console.ReadLine();
            int integer;
            
            while (!int.TryParse(Console.ReadLine(), out integer))
            {
                Console.WriteLine("Kļūda ievadē: Skaitlis nav vesels");
                
            }

       Console.WriteLine(integer);
           
        }
    }
}
