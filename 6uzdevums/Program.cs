using System;

namespace _6uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mums ir māja ar 5 stāviem un pagrabu.Lietotājam tiek paprasīts ievadīt mājas priekšmetu, piemēram, “galds”,
            //un mūsu programmai ir jāizvada, kurā stāvā šis priekšmets tiks novietots. Nosacījumi priekšmeta novietšanai ir: 
            //Priekšmeti, kuri sākas ar burtiem a,b,c,d tiks novietoti 1.Stāvā.
            //    Priekšmeti, kuri sākas ar burtiem e,f,g,h tiks novietoti 2.Stāvā.Nākamie burti attiecīgi 3., 4.un 5.stāvā.
            //    Visi pārējie priekšmeti tiks novietoti pagrabā.
    Console.WriteLine("Lūdzu, ievadiet priekšmetu, kuru vēlaties glabāt: ");
            var userinput = Console.ReadLine();
            var object1 = userinput.Substring(0, 1);

            if (userinput.Substring(0, 1) == "a" ||
                userinput.Substring(0, 1) == "b" ||
                userinput.Substring(0, 1) == "c" ||
                userinput.Substring(0, 1) == "d")
            {
                Console.WriteLine("Jūsu priekšmets tiks novietots 1 stāvā!");
            }
            else if (userinput.Substring(0, 1) == "e" ||
                userinput.Substring(0, 1) == "f" ||
                userinput.Substring(0, 1) == "g" ||
                userinput.Substring(0, 1) == "h")
            {
                Console.WriteLine("Jūsu priekšmets tiks novietots 2 stāvā!");
            }

            else if (userinput.Substring(0, 1) == "i" ||
                userinput.Substring(0, 1) == "j" ||
                userinput.Substring(0, 1) == "k" ||
                userinput.Substring(0, 1) == "l")
            {
                Console.WriteLine("Jūsu priekšmets tiks novietots 3 stāvā!");
            }

            else if (userinput.Substring(0, 1) == "m" ||
               userinput.Substring(0, 1) == "n" ||
               userinput.Substring(0, 1) == "o" ||
               userinput.Substring(0, 1) == "p")
            {
                Console.WriteLine("Jūsu priekšmets tiks novietots 4. stāvā!");
            }

            else if (userinput.Substring(0, 1) == "r" ||
               userinput.Substring(0, 1) == "s" ||
               userinput.Substring(0, 1) == "t" ||
               userinput.Substring(0, 1) == "v")
            {
                Console.WriteLine("Jūsu priekšmets tiks novietots 5 stāvā!");
            }
            else
            {
                Console.WriteLine("Jūsu priekšmets tiks novietots pagrabā");
            }
        }
    }
}


