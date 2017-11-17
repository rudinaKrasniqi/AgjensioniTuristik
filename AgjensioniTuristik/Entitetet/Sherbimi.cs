using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgjensioniTuristik
{
    class Sherbimi
    {
        //Variablat instance
     
        DateTime _dataNisjes;
        DateTime _dataMberritjes;

        Vendi _vendNisja;
        Vendi _destinacioni;

        string _llojiTransportit;
        double _qmimi;


        //Properties - Veqorite
        public Vendi VendNisja
        {
            get { return _vendNisja; }
            set { _vendNisja = value; }
        }
        public Vendi Destinacioni
        {
            get { return _destinacioni; }
            set { _destinacioni = value; }
        }

        public string LLojiTransport
        {
            get { return _llojiTransportit; }
            set
            {
                if (value != String.Empty || value == " ")
                    _llojiTransportit = value;

            }
        }

        public DateTime DataNisjes
        {
            get { return _dataNisjes; }
            set { _dataNisjes = value; }

        }

        public DateTime DataMberritjes
        {
            get { return _dataMberritjes; }
            set { _dataMberritjes = value; }

        }

        public double Qmimi
        {
            get { return _qmimi; }
            set
            {
                if (value > 0)
                    _qmimi = value;

            }
        }
    }
}
