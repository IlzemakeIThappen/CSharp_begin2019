using System;

namespace Forcikls2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Izveidot string masīvu ar cilvēku vārdiem(Vēlams ne mazāk kā 3).
            //1.Izdrukāt visus vārdus.
            //2.Izdrukāt tikai tos vārdus, kuri sākās ar "J".
            //Izmantojam Substring metodi.
            string [] names = new[] { "Jānis", "Pēteris", "Amanda", "Surikāts" };

            for (int i = 0; i < names.Length; i++)
            {           
                
                Console.WriteLine(names[i]);

            }
                  

                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i].StartsWith("J"))
                    {
                        Console.WriteLine(names[i]);
                    }

                }
            
        }
       
    }
}
