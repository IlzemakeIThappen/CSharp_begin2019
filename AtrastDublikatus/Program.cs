using System;
using System.Linq;

namespace AtrastDublikatus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzrakstīt programmu, kas no masīva izmet visus duplikātus - 
            //    vērtības, kas atkārtojas vairāk kā vienu reizi.
            //    Piemērs[“ABC”,”CDE”,”FGA”,”CDE”,”GAE”,”ABC”,”ABO”]-> [“ABC”,”FGA”,”CDE”,”GAE”,”ABO”]

            string[] dublikati = new[] { "ABC","CDE","FGA","CDE","GAE","ABC","ABO"};

                var result = dublikati.Distinct();
            foreach (var value in result)
            {
                Console.WriteLine(value);
            }
            
        }
    }
}
