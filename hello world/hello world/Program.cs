using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kā Tev klājas?");
            var name = Console.ReadLine();
            Console.WriteLine($"\nsuper, ka, {name} ! ");
            Console.Write("\nNospied kaut ko un turpini...");
            Console.ReadKey(true);
        }
    }
}
