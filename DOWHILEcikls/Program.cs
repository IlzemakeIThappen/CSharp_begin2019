using System;

namespace DOWHILEcikls
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot console aplikāciju, kurā ir definēts string tipa masīvs ar cilvēku vārdiem.
            //    Izmantojot do while ciklu izdrukāt visus vārdus.

            string[] names = new[] { "Sanra", "Jurijs", "Andrejs", "Vladis", "Andra" };

            int k = 0;
          
            do
            {
                Console.Write(" " + names[k]);
                k++;
            } while (k < names.Length);

        }
    }
}
