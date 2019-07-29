using System;

namespace _8._1uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            //izveidot console aplikāciju, kura paprasa lietotājam vai viņš grib pusdienas.
            //    Ja lietotājs ir ievadījis TRUE, tad uz ekrāna izdrukāt "Jūsu pusdienas ir gatavas", 
            //ja lietotājs ir ievadījis FALSE, tad "Jums pusdienas nebūs".
            //    IF ELSE nosacījumā ir jāizmanto bool tipa mainīgais, nevis string tipa mainīgais.
            //    Lai no lietotāja ievadītā teksta iegūtu bool tipa mainīgo ir jāizmanto bool.Parse,
            //līdzīgi kā ar konvertēšanu uz veselu skaitli.
         Console.WriteLine("Vai Jūs vēlaties pusdienas?");
            var userinput = Console.ReadLine();
            bool pusdienas = bool.Parse(userinput);

            if (pusdienas==true)
            {
                Console.WriteLine("Jūsu pusdienas ir gatavas...");
            }
            else if (pusdienas == false)
            {
                Console.WriteLine("Jums pusdienas nebūs...");
            }
        }
    }
}
