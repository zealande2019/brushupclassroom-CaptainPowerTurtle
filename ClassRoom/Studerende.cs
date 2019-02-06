using System;
using System.ComponentModel;

namespace ClassRoom
{
    public class Studerende
    {

        public Studerende(string navn, int fødselsdag, int fødselsmåned)
        {
            Navn = navn;
            Fødselsdag = fødselsdag;
            Fødselsmåned = fødselsmåned;
            if (fødselsmåned <= 0 || fødselsmåned > 12)
            {
                throw new ArgumentException();
            }
        }

        public string Navn { get; set; }
        public int Fødselsdag { get; set; }
        public int Fødselsmåned { get; set; }

        public string Årstid ()
        {
            string årstid;
            if ((Fødselsmåned == 12) || (Fødselsmåned == 1) || (Fødselsmåned == 2))
            {
                årstid = "Vinter";
            }
            if ((Fødselsmåned == 3) ||(Fødselsmåned == 4) || (Fødselsmåned == 5))
            {
                årstid = "Forår";
            }
            if ((Fødselsmåned == 6) || (Fødselsmåned == 7) || (Fødselsmåned == 8))
            {
                årstid = "Sommer";
            }
            else
            {
                årstid = "Efterår";
            }

            return årstid;
        }
    }
}