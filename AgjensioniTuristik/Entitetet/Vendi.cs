using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgjensioniTuristik
{
    class Vendi
    {
        static int _counterID;
        readonly int _ID;
        string _emri;
        string _regjioni;
        string _kontinenti;

        public string Emri
        {
            get { return _emri; }
            set
            {
                if (value != String.Empty)
                    _emri = value;
            }
        }
        public string Regjioni
        {
            get { return _regjioni; }
            set
            {
                if (value != String.Empty)
                    _regjioni = value;
            }
        }
        public string Kontinenti
        {
            get { return _kontinenti; }
            set
            {
                if (value != String.Empty)
                    _kontinenti = value;
            }
        }

        public Vendi()
        {
            _counterID++;
            _ID = _counterID;
        }
    }
}
