using System.Threading.Tasks.Sources;

namespace IhmisApplikaatio
{

    abstract class Ihminen
    {
        //Yksityiset muuttujat/j�sen muutujat
        private string _nimi;
        private int _ika;

        //Konstruktori
        public Ihminen(string nimi, int ika)
        {
            this._nimi = nimi;
            this._ika = ika;
            Console.WriteLine("Luodaan objektia nimi: " + _nimi + " Ik�: " + _ika + ", ");
        }

        //Destructor
        ~Ihminen()
        {
            Console.WriteLine("Goodbye, ote lipee");
        }


        //Alust nimi/j�sen funktio
        public void setNimi(string nimi)
        {
            this._nimi = nimi;
        }
        //Alusta ik�/j�sen funktio
        public void setIka(int ika)
        {
            this._ika = ika;
        }

        //P��sy nimeen
        public string getNimi()
        {
            return this._nimi;
        }
        //P��sy ik��n
        public int getIka()
        {
            return this._ika;
        }
        public void getVanhene()
        {
            int i = 1;
            if (_ika > i)
            {
                _ika++;
            }

        }
        public string getMoi()
        {
            return "Hei, olen " + getNimi() + " ja olen " + getIka() + " vuotta vanha.";
        }
    }

    class Suomi : Ihminen
    {
        private double _sisu;

        public void tervehdi()
        {
            Console.WriteLine("Terve,");
            Console.WriteLine("Nimeni on " + getNimi());
            Console.WriteLine("Ik�ni on " + getIka());
            Console.WriteLine("Sisua on " + getSisu());
            Console.WriteLine("Olen suomalainen!");
        }

        public Suomi(string nimi, int ika, double sisu) :
            base(nimi, ika)
        {
            _sisu = sisu;
        }

        public double getSisu()
        {
            return _sisu;
        }
    }

    class Ruotsi : Ihminen
    {
        private double _onni;

        public void tervehdi()
        {
            Console.WriteLine("Hejsan!, ");
            Console.WriteLine("Jag heter: " + getNimi());
            Console.WriteLine("Jag �r: " + getIka() + " �r.");
            Console.WriteLine("Jag �r svensk!");
        }

        public Ruotsi(string nimi, int ika, double onni) :
            base(nimi, ika)
        {
            _onni = onni;
        }

        public double getOnni()
        {
            return _onni;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {   //Luo objekti
            /*
            //T�ss� on 1-3 teht�vist�!!!
            Ihminen ihminen = new Ihminen("Emil", 26);
            //Aseta yksityisten muuttujien arvo
            Console.Write("Mik� on nimesi?: ");
            ihminen.setNimi(Console.ReadLine());
            Console.Write("Mik� on sinun ik�si?: ");
            ihminen.setIka(Convert.ToInt32(Console.ReadLine()));
            //Yksityisten muuttujien arvon saaminen
            Console.WriteLine("Nimi: " + ihminen.getNimi());
            Console.WriteLine("Ika: " + ihminen.getIka());
            
            Console.WriteLine("-----------");
            
            ihminen.getVanhene();
            Console.WriteLine(ihminen.getMoi());
            */
            Suomi suomi = new Suomi("Pentti", 24, 23.5);
            Console.WriteLine(suomi.getSisu());
            suomi.tervehdi();
            Ruotsi ruotsi = new Ruotsi("Tom", 28, 2000);
            Console.WriteLine(ruotsi.getOnni());
            ruotsi.tervehdi();
        }
    }
}