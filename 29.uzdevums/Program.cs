using System;
using System.Collections.Generic;

namespace _29.uzdevums
{
    public class Program
    {
        

       public static void Main(string[] args)
        {
            //            Definēt programmas sākumā string[] ar vērtībām {“Jānis”, ””, “Pēteris”, “Antons”, “”, “Andris”}. 
            //Izveidot metodi GetNonEmtyArray, kura kā paramatru saņem string[] un lietotājam atgriež string[],
            //                kurā vairs nav tukšo vērtību. Lai nodemonstrētu GetNonEmptyArray metodes darbību,
            //            izmantojiet metodi PrintArrayValues,
            //            kura vispirms izdrukā sākotnējā masīva vērtības, bet vēlāk masīvu, kurā vairs nav tukšās vērtības.
          
            string[] names = new string[] { "Jānis", "", "Pēteris", "Antons", "", "Andris" };
            foreach (var name in names)
            {
                Console.WriteLine($"Saraksts ar tukšajiem ievades laukiem:   {name}");
                
            }
            Console.WriteLine();
            Console.WriteLine("Bez tukšumzīmēm:  ");
            GetNonEmtyArray();
        }
       

        public static void GetNonEmtyArray()
        {
           
            string[] trimnames = new[] { "Jānis", "", "Pēteris", "Antons", "", "Andris" };
       
            for (int i = 0; i < trimnames.Length; i++)
            {
                
                if (trimnames[i].Length > 1)
                {

                    Console.WriteLine(trimnames[i]);

                }

            }


        }

    }
}
