using System;


namespace _27.uzdevums
{
    class GFG
    {
        public void fullName (string name)
        {
           
            Console.WriteLine("Name: " + name);
        }

        public void fullName (string name, string surname)
        {
            
        
            Console.WriteLine("Name:  " + name + ", " + "Surname: " + surname);
        }
        static void Main(string[] args)
        {
            GFG PrintNameSurname = new GFG();
            Console.WriteLine("Ievadiet vārdu:");
            string name = Console.ReadLine();
            PrintNameSurname.fullName(name);

            Console.WriteLine("Ievadiet uzvārdu:");
            string surname = Console.ReadLine();
            if (surname=="")
            {
                surname = "Nezināms";
            }
            PrintNameSurname.fullName(name, surname);

            

            //Izmantojot metožu overload iespējas definēt metodi PrintNameSurname, 
            //kura vienā gadījumā strādā ar vienu ieejas parametru name, 
            //bet otrajā gadījumā ar diviem parametriem name un surname.
            //    Pēc veiksmīga rezultāta sasniegšanas modificēt metodi PrintNameSurname, tā, 
            //lai tai būtu tikai divi parametri un ja lietotājs nav ievadījis uzvārdu, 
            //    tad uzvārda vietā rakstītos teksts “Nezināms”.

        }
    }
}
