using System;

namespace _30.uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            //izveidot static metodi CalculateSum atsevišķā failā. Metodei , 
            //kā parametri ir jāsaņem divas int vērtības x un y.
            //    Šai metodei ir jāatgriež šo skaitļu summa.
            //    Šo metodi ir jāizmanto vairākas reizes galvenajā programmā.
            
           // CalculateSum1.CalculateSum();

            
                
                    Console.WriteLine("Ievadiet pirmo skaitli:  ");
                    var userinput = Console.ReadLine();
                    int x = Convert.ToInt32(userinput);
                    Console.WriteLine("Ievadiet otro skaitli:  ");
                    var userinput1 = Console.ReadLine();
                    int y = Convert.ToInt32(userinput1);
                
            if (x!=3)
            {
           CalculateSum1.CalculateSum();
            

            }
            else
            {
                Console.WriteLine("Ievadiet, lūdzu, skaitli, kurš ir lielāks par 3!!!");
            }

            
        }
      
    }
}
