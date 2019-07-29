using System;

namespace _8._2_bool_datu_tips
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarēt programmā bool tipa mainīgo, kura sākotnējā vērtība ir TRUE.Izveidot while ciklu, 
            //    kurš atkārtojas tik ilgi kamēr mainīgā vērtība ir TRUE.Mainīgā vērtību uz FALSE ir jānomaina,
            //    tad, kad cikls ir atkārtojies 20 reizes.
            int i = 1;
            bool reizes =i <=20;
           // int i = bool.TryParse(reizes);
            while (reizes==true)
            {
                Console.WriteLine("Value of reizes: {0}", i);
               i++;

                if (i > 20)
                {
                    break;
                }
            }
        }
            
            //bool vertiba = true;


            //int i = 1;

            //while (true)
            //{
            //    Console.WriteLine("Value of i: {0}", i);

            //    i++;

            //    if (i > 20)
            //        break;
            //}
            //int i = 0;

            //do
            //{
            //    Console.WriteLine("Value of i: {0}", i);

            //    i++;

            //    if (i > 19)
            //        break;

            //} while (true);

        
    }
}
