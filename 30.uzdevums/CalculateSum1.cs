using System;
using System.Collections.Generic;
using System.Text;

namespace _30.uzdevums
{
    public class CalculateSum1
    {
        public static int CalculateSum()
        {
           int  x = Convert.ToInt32(Console.ReadLine());
           int y = Convert.ToInt32(Console.ReadLine()); 
            int sum = x + y;
            
            return  sum;
           
        }
    }
}
//izveidot static metodi CalculateSum atsevišķā failā. Metodei , 
//kā parametri ir jāsaņem divas int vērtības x un y.
//    Šai metodei ir jāatgriež šo skaitļu summa.
//    Šo metodi ir jāizmanto vairākas reizes galvenajā programmā.