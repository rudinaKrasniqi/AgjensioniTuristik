using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgjensioniTuristik
{
    class Bileta
    {
        //variablat instance
        static int _counterID;
        readonly int _ID;

       
        string _llojiTransportit;
        double _qmimi;

        //Statusi qe percakton se bileta a eshte e rezervuar apo jo
        //nese true bileta eshte e rezervuar
        //nese false bileta ne dispozicion
        bool statusBileta;
       

        Vendi _vendNisja;
        Vendi _destinacioni;

        DateTime _dataNisjes;
        DateTime _dataMberritjes;
        DateTime _dataRezervimit;

        Oferta oferta;
        Sherbimi sherbimi;

       
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

        public string LLojiTransport {
            get { return _llojiTransportit; }
            set { if (value != String.Empty)
                    _llojiTransportit = value;

            }
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

        public Oferta Oferta
        {
            get{ return oferta; }
            set {
                if (sherbimi == null)
                {
                    oferta = value;
                }
            }
                
        }

        public Sherbimi Sherbimi
        {
            get { return sherbimi; }
            set
            {
                if (oferta==null)
                {
                    sherbimi = value;
                }
            }
        }

        public DateTime DataRezervimi
        {
            get { return _dataRezervimit; }
            set { value=DateTime.Now; }
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
  

   

        //Konstruktori
        public Bileta()
        {
            _counterID++;
            _ID =_counterID;
        }

        public Bileta(DateTime dataNisjes,DateTime dataMberritje,string llojiTransportit,double Qmimi,Vendi vendNisja,Vendi destinacioni)
        {
            VendNisja = vendNisja;
            Destinacioni = destinacioni;
            this._dataNisjes = dataNisjes;
            this._dataMberritjes = dataMberritje;
            this.LLojiTransport = llojiTransportit;
            this.Qmimi = Qmimi;
            
            _counterID++;
            _ID=_counterID;

        }
    
        public void ParaqitBileten()
        {
            Console.WriteLine("Vendi i nisjes: "+VendNisja);
            Console.WriteLine("Destinacioni: "+Destinacioni);
            Console.WriteLine("Data e nisjes: "+DataNisjes);
            Console.WriteLine("Data e mberritjes: "+DataMberritjes);
            Console.WriteLine("LLoji i transporit: "+LLojiTransport);
            Console.WriteLine("Qmimi: "+Qmimi);
            Console.WriteLine("Statusi i biletes: "+(statusBileta==true? "Rezervuar ": "Ne dispozicion"));
        }
       

      
    }
}
