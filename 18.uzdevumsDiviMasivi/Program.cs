using System;
using System.Linq;

namespace _18.uzdevumsDiviMasivi
{
    class Program
    {


        static void Main(string[] args)
        {
            //Ir definēti divi string tipa masīvi, pirmajā masīvā atrodas cilvēku vārdi, otrajā cilvēku uzvārdi.
            //    Abu masīvu lielums ir identisks(10 ieraksti).
            //    Izveidot tādu programmu, kur Vārdi un Uzvārdi tiek apvienoti vienā masīvā un izdrukāti uz ekrāna.

            string[] names = new[] { "Jānis", "Sarmīte", "Ilze", "Olga", "Kaspars", "Juris", "Santa", "Inārs", "Minka", "Aleksejs" };
            string[] surnames = new[] { "qw", "er", "ty", "ui", "op", "as", "df", "gh", "jk", "lz" };

            var arr = names.Concat(surnames).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

           
        }

    }
}
