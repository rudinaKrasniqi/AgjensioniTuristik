using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgjensioniTuristik
{
    class Adresa
    {
        string _emriRruges;
        int _nrShtepise;
        string _qyteti;
        int _zipCode;
        string _shteti;

        public string EmriRruges
        {
            get { return _emriRruges; }
            set { _emriRruges = value; }
        }

        public int NrShtepise
        {
            get { return _nrShtepise; }
            set { _nrShtepise = value; }
        }

        public string Qyteti
        {
            get { return _qyteti; }
            set { _qyteti = value; }
        }

        public int ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        public string Shteti
        {
            get { return _shteti; }
            set { _shteti = value; }
        }
    }
}
