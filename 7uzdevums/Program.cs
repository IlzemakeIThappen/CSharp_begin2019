using System;

namespace _7uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
//            Jūs esat ziemassvētku tirdziņā nopirkuši eglīti, 
//                eglīti raksturo trīs parametri augstums,
//                zaru diametrs un eglītes veids(tradicionālā eglīte vai sudrabegle).
//            Eglītes parametri var tikt definēti gan kā mainīgie programmā, gan tos var
//                paprasīt arī lietotājam. Atkarībā no eglītes augstuma, zaru diametra vai eglītes tipa, 
//                to ir jānovieto atbilstošā telpā mājā.Ja eglīte ir sudrabegle, to drīkst novietot tikai kamīnzālē. 

//Augstums(cm)   Zaru diamtrs(cm)   Telpa
//50 <= x < 100   100 <= y < 150  Viesistaba 1
//100 <= x < 150  150 <= y < 200  Viesistaba 2
//150 <= x <= 300 200 <= y <= 300 Kamīnzāle
            Console.WriteLine("Lūdzu, uzrakstiet, cik augsta ir Jūsu eglīte: ");
            var userinput = Console.ReadLine();
            var augstums = Convert.ToInt32(userinput);

            Console.WriteLine("Lūdzu, uzrakstiet, kāds ir Jūsu eglītes diametrs: ");
            var userinput1 = Console.ReadLine();
            var diametrs = Convert.ToInt32(userinput1);

            Console.WriteLine("Kādu eglīti Jūs iegādājāties (tradicionala vai sudrabegle)? ");
            var userinput3 = Console.ReadLine();
           
            if (50 <= augstums && augstums < 100 && 100 <= diametrs && diametrs < 150 && userinput3 != "sudrabegle")
            {
                Console.WriteLine("VIESISTABA1");
            }

           else if (100 <= augstums && augstums < 150 && 150 <= diametrs && diametrs < 200 && userinput3 != "sudrabegle")
            {
                Console.WriteLine("VIESISTABA2");
            }
            if (150 <= augstums && augstums < 300 && 200 <= diametrs && diametrs < 300 )
            {
                Console.WriteLine("KAMĪNZĀLE");
            }
            else
            {
                Console.WriteLine("Tādas eglītes pie mums nepārdodas, lūdzu, pārbaudiet VĒLREIZ!");
            }
        }
    }
}
