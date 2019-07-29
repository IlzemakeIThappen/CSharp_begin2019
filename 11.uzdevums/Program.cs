using System;

namespace _11.uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Izvedot console aplikāciju, kurā ir definēts string tipa masīvs ar sākotnējām vērtībām
            //"Jānis", "Pēteris", "Andris".
            //Izvadīt uz ekrāna masīva otrā elementa vērtību("Pēteris").Samainīt masīva 3 elementa vērtību no "Andris" uz "Jēkabs".
            string[] Names = new[] { "Jānis", "Pēteris", "Andris" };
            
            string izvade ;
            
            for (int i = 0; i < Names.Length; i++)
            {
                izvade = Names[i];
                if (izvade=="Andris")
                 {
                    izvade = "Jēkabs";
                 
                 }
                              
            }
            Console.WriteLine(Names[1]);
        }
    }
}
