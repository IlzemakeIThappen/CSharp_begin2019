using System;

namespace _8._3_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ir trīs krustojumi.Lietotājs, ievada informāciju par to, 
            //    vai konkrētajam krustojumam var izbraukt cauri.
            //    Programmai ir jāpārbauda, vai ir iespējams visiem krustojumiem izbraukt cauri.
            Console.WriteLine("IZBRAUKŠANA cauri 1.krustojumam- TRUE OR FALSE?");
            var userinput = Console.ReadLine();

            bool go1 = Convert.ToBoolean(userinput);

            if (go1 == true)
            {
                Console.WriteLine("SUPER KRUSTOJUMS");
            }
            else
            {
                Console.WriteLine("TE LABĀK NEBRAUC");
            }

            Console.WriteLine("IZBRAUKŠANA cauri 2.krustojumam- TRUE OR FALSE?");
            var userinput2 = Console.ReadLine();

            bool go2 = Convert.ToBoolean(userinput2);

            if (go2 == true)
            {
                Console.WriteLine("SUPER KRUSTOJUMS");
            }
            else
            {
                Console.WriteLine("TE LABĀK NEBRAUC");

            }

            Console.WriteLine("IZBRAUKŠANA cauri 3.krustojumam- TRUE OR FALSE?");
            var userinput3 = Console.ReadLine();

            bool go3 = Convert.ToBoolean(userinput3);

            if (go3 == true)
            {
                Console.WriteLine("SUPER KRUSTOJUMS");
            }
            else
            {
                Console.WriteLine("TE LABĀK NEBRAUC");
            }
            
            Console.WriteLine("KOPSAVILKUMS:");
            while (go1==true)
            {
                Console.WriteLine("Jūs varat izbrauk caur 1.krustojumu ");
                break;
            }
            while (go2 == true)
            {
                Console.WriteLine("Jūs varat izbrauk caur 2.krustojumu ");
                break;
            }
            while (go3 == true)
            {
                Console.WriteLine("Jūs varat izbrauk caur 3.krustojumu ");
                break;
            }
        }
    }
}

