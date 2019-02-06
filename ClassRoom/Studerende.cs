namespace ClassRoom
{
    public class Studerende
    {
        private string _navn;
        private int _fødselsmåned;
        private int _fødselsdag;

        public Studerende(string navn, int fødselsdag, int fødselsmåned)
        {
            _navn = Navn;
            _fødselsdag = Fødselsdag;
            _fødselsmåned = Fødselsmåned;
        }
        public string Navn
        {
            get { return _navn; }
        }
        public int Fødselsmåned
        {
            get { return _fødselsmåned; }
        }
        public int Fødselsdag
        {
            get { return _fødselsdag; }
        }
    }
}