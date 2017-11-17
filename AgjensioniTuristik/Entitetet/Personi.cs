using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgjensioniTuristik
{
    class Personi
    {
       
        //variablat instance
        string _emri;
        string _mbiemri;
        string _email;
        string _nrTel;

       
        DateTime datelindja;

        Adresa adresa;
        
        //veqorite - properties
        public string Emri
        {
            get { return _emri; }
            set
            {
                while (value == String.Empty || value==" ")
                {
                    Console.Write("Ju lutem shkruani emrin: ");
                    value = Console.ReadLine();
                }
                _emri = value;
            }
        }

        public string Mbiemri
        {
            get { return _mbiemri; }
            set
            {
                while (value == String.Empty || value == " ")
                {
                    Console.Write("Ju lutem shkruani mbiemrin: ");
                    value = Console.ReadLine();
                }
                _mbiemri = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                while (value == String.Empty || value == " ")
                {
                    Console.Write("Ju lutem shkruani e-mailin tuaj: ");
                    value = Console.ReadLine();
                }
                _email = value;
            }
        }

        public string NumriTelefonit
        {
            get { return _nrTel; }
            set
            {
               while(value == String.Empty || value == " ")
                {
                    Console.Write("Ju lutem shkruani numrin e telefonit: ");
                    value = Console.ReadLine();
                }
            }
        }

        public DateTime Datelindja { get { return datelindja; } set { datelindja = value; } }
        
        public Adresa Adresa { get { return adresa; } set { adresa = value; } }
    }
}
