using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgjensioniTuristik
{
    class Klienti :Personi
    {
        static int ID;
        readonly int vleraID;

        //Variablat instance
        string _username;
        string _password;

        //Veqorite - Properties
        public string Username
        {
            get { return _username; }
            set
            {
               while(value == String.Empty || value == " ")
                {
                    Console.Write("Shtypeni emrin e perdorimit tuaj: ");
                    value = Console.ReadLine();
                }
                    _username = value;
            }
        }
        public string Password 
        {
            get { return _password; }
            set
            {
                while(value == String.Empty || value ==" ")
                {
                    Console.Write("Shtypni fjalekalimin: ");
                    value = Console.ReadLine();
                }
                _password = value;
            }
        }

        //Mbingarkimi i konstruktoreve
        public Klienti()
        {
            ID++;
            vleraID = ID;
        }

        public Klienti(string emri,string mbiemri,string email,string nrTel,string username, string password)
        {
            ID++;
            vleraID = ID;

            Emri = emri;
            Mbiemri = mbiemri;
            Email = email;
            NumriTelefonit = nrTel;

            Username = username;
            Password = password;
        }
    }
}
