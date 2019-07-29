using System;

namespace ifins
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=10;
            Console.WriteLine("Lūdzu ievadiet skaitli");
           
            string  UserInput = Console.ReadLine();
       
            Console.WriteLine("Jūs ievadījāt:  " + UserInput);
            

            if (x > 10)
            {
                
                Console.WriteLine("Skaitlis ir lielāks par 10");
                
                            }
            else
            {
                Console.WriteLine("Skaitlis ir vienāds vai mazāks par 10");

            }


        }
    }
}
