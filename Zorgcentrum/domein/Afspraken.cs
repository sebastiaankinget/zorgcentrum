using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zorgcentrum.domein
{
    public class Afspraken
    {
        private int _afspraakid;

        public int Afspraakid
        {
            get => _afspraakid;           init           {
                _afspraakid = value;            } }


        private string _type;
        public string Type
        {
            get => _type;
            init
            {
                _type = value;
            }
        }
        private int _duurMin;

        public int DuurMin
        {
            get => _duurMin; init
            {
                _duurMin = value;
            }
        }

        private int _rijksregisterNrPatiënt;

        public int RijksregisterNrPatiënt
        {
            get => _rijksregisterNrPatiënt; init
            {
                _rijksregisterNrPatiënt = value;
            }
        }
        private int _rijksregisterNrArts;

        public int RijksregisterNrArts
        {
            get => _rijksregisterNrArts; init
            {
                _rijksregisterNrArts = value;
            }
        }
        private string _afdelingCode;

        public string AfdelingCode
        {
            get => _afdelingCode; init
            {
                _afdelingCode = value;
            }
        }
        private string _extra1;
        public string Extra1
        {
            get => _extra1; init
            {
                _extra1 = value;
            }
        }
        private int _extra2;
        public int Extra2
        {
            get => _extra2; init
            {
                _extra2 = value;
            }
        }


        private DateTime _datuumtijdstart;

        public DateTime Datuumtijdstart {

            get => _datuumtijdstart;
            init
            {
                _datuumtijdstart = value;
            }
        }
    
       
        public Afspraken(int afspraakid, string type, DateTime datuumtijdstart , int duurMin , int rijksregisterNrPatiënt , int rijksregisterNrArts,
            string afdelingCode , string extra1 , int extra2)
        {
            Afspraakid = afspraakid;
            Type = type;
            Datuumtijdstart = datuumtijdstart;
            DuurMin = duurMin;
            RijksregisterNrPatiënt = rijksregisterNrPatiënt;
            RijksregisterNrArts=rijksregisterNrArts;
            AfdelingCode = afdelingCode;
            Extra1 = extra1;
         
            Extra2 = extra2;
        }

     

        public void IntroduceAfspraken()
        {
            Console.WriteLine($"{Afspraakid}   {Datuumtijdstart}");

        }
    }


}
