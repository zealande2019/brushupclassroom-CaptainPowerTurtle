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
            KlasseRum klasseRum1 = new KlasseRum();
            klasseRum1.KlasseNavn = "3B";
            klasseRum1.SemesterStart = new DateTime(2018, 09, 04);
            
            Studerende Studerende1 = new Studerende("Jacob", 16, 08);
            Studerende Studerende2 = new Studerende("Lasse", 16, 08);
            Studerende Studerende3 = new Studerende("Marcel", 16, 08);

            klasseRum1.Klasseliste.Add(Studerende1);
            klasseRum1.Klasseliste.Add(Studerende2);
            klasseRum1.Klasseliste.Add(Studerende3);

            foreach (var studerende in klasseRum1.Klasseliste)
            {
                Console.WriteLine($"Disse elever går her: {studerende.Navn} og har fødselsdag: {studerende.Fødselsdag}/{studerende.Fødselsmåned} og går i klassen {klasseRum1.KlasseNavn} som starter {klasseRum1.SemesterStart}");
            }

            foreach (var studerende in klasseRum1.Klasseliste)
            {
                Console.WriteLine(studerende.Årstid());
            }


            Console.ReadLine();
        }
    }
}
