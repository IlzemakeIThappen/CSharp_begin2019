using System;
using System.Text;

namespace Math.Random
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definēt int masīvu, kura lielums ir 10.
            //    No koda piešķirt visiem masīva elementiem vērtības. 
            int[] numbers = new int[10];
            numbers[0] = 100;
            numbers[1] = 50;
            numbers[2] = 60;
            numbers[3] = 300;
            numbers[4] = 90;
            numbers[5] = 500;
            numbers[6] = 5000;
            numbers[7] = 70;
            numbers[8] = 90;
            numbers[9] = 9000;

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
