using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Zorgcentrum.domein
{
    public class Artsen : Persoon
    {
        private int[] _afdelingen;

        public Array Afdelingen
        {
            get => _afdelingen;

            init { _afdelingen = (int[])value; }

        }



        private string _RIZIV;

        public string RIZIV
        {
            get => _RIZIV;
            init
            {


                _RIZIV = value;
            }
        }
        private string _specialisatie;
        private string v1;
        private string v2;
        private object value;

        public string Specialisatie
        {
            get => _specialisatie;
            init
            {


                _specialisatie = value;
            }
        }

        public Artsen(string rijkregisternummer, string naam, string voornaam, string rIZIV, string specialisatie, int[] afdelingen) : base(rijkregisternummer, naam, voornaam)
        {
            Afdelingen = afdelingen;
            RIZIV = rIZIV;
            Specialisatie = specialisatie;
        }


        public void Artintroduce()
        {
            Console.WriteLine($"{Rijkregisternummer}  {Naam}        {Voornaam}       {RIZIV}       {Specialisatie}       {Afdelingen} ");

        }
    }
}
