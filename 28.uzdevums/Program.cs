using System;

namespace _28.uzdevums
{
    class GFG
    {
        static void Main(string[] args)
        {
            // int[] values = new[] { 1, 34, 55, 44, 2, 3 };
            int[] numberArray = { 1, 34, 55, 44, 2, 3 };
            string[] nameArray = new[] { "Jānis", "Ilze", "Sarmīte" };
            //Izveidot metodi PrintArrayValues, kura kā parametru saņem int[] un izdrukā visas tā vērtības. 
            //    Izmantojot metožu overload funkciju definēt metodi PrintArrayValues,
            //kura kā parametru saņem string[] un var izdrukāt string[] visas vērtības.
            GFG val = new GFG();
            val.PrintArrayValues(numberArray);
            val.PrintArrayValues(nameArray);
        }
        public void PrintArrayValues(int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
        }
        public void PrintArrayValues(string[] names)
        {
           
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
