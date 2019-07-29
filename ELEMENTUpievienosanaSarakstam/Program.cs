using System;
using System.Collections.Generic;

namespace ELEMENTUpievienosanaSarakstam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot tukšu string sarakstu(List). 
            //Izmantojot console applikāciju paprasīt lietotājam ievadīt vārdu.
            //    Ievadītais vārds ir jāpievieno sarakstam.
            //    Programmai ir jāļauj ievadīt 1...n vārdus. Ir jābūt iespējai izdrukāt ievadītos vārdus.
            List<string> namelists = new List<string>();
   

            do
            {
                Console.WriteLine("Lūdzu, ievadiet vārdu:  ");
                 var name = Console.ReadLine();
                namelists.Add(name);
                Console.WriteLine("Vai Jūs vēlaties ievadīt vēl vienu vārdu? (y/n)  ");
                var jaut= Console.ReadLine();
               if (jaut == "n")
                {
                    break;
                    
                }
               
            } while (true);

           

            foreach (string name in namelists)
            {
               
                Console.WriteLine(name);
            }
           
        }
    }
}
