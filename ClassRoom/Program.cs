using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime justDate = new DateTime(2018, 04, 18);
            KlasseRum klasserum1 = new KlasseRum { KlasseNavn = "3B", Klasseliste = new List<Studerende>(), SemesterStart = justDate};

            klasserum1.Klasseliste.Add(new Studerende("Jacob", 08, 1996));
            klasserum1.Klasseliste.Add(new Studerende("Lasse", 09, 1996));
            klasserum1.Klasseliste.Add(new Studerende("Marcel", 10, 1996));

            Console.WriteLine(klasserum1.KlasseNavn);
            Console.WriteLine(klasserum1.SemesterStart);
            Console.WriteLine(klasserum1.Klasseliste.ToString());
            foreach (var stud in klasserum1.Klasseliste)
            {
                Console.WriteLine(stud.ToString());
            }
        }
    }
}
