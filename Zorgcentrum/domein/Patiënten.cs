using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zorgcentrum.domein
{
    public class Patiënten : Persoon
    {
        private int[] _afdelingen ;

        public Array Afdelingen {
            get => _afdelingen;

            init { _afdelingen = (int[])value;  }
        
        }


        public Patiënten(string rijkregisternummer, string naam, string voornaam , int[] afdelingen  ) : base(rijkregisternummer, naam, voornaam)
        {
            Afdelingen = afdelingen;
        }

       

        public void intt()
        {
            Console.WriteLine($"{Rijkregisternummer}  {Naam}        {Voornaam}              {Afdelingen} ");

        }
    }
}
