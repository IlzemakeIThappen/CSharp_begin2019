using System;

namespace _26.uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot divas metodes GetNameSurname un PrintNameSurname. 
            //    Metodei GetNameSurname ir no lietotāja jāpaprasa vārds uzvārds 
            //    un kā string jāatgriež metodei PrintNameSurname, 
            //    kura šo tekstu izdrukās console.
            GetNameSurname();
            PrintNameSurname();
        }
        public static void GetNameSurname()
        {
            Console.WriteLine("Ievadiet vārdu un uzvārdu:  ");
        }
        public static void PrintNameSurname()
        {
            string fullName = Console.ReadLine();
            Console.WriteLine(fullName);
        }
    }
}
