using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgjensioniTuristik
{
    class Log_In
    {
        //Krijimi i listes se perdoruesve 
        List<Klienti> Perdoruesit = new List<Klienti>() {
            new Klienti("Rudina","Krasniqi","rudine.krasniqi@riinvest.net","44123123","rudinek","rudina123"),
            new Klienti("Fiton","Xharra","fiton.xharra@riinvest.net","44121121","fitonxh","fiton123"),
            new Klienti("Dafina","Uruqi","dafina.uruqi@riinvest.net","44123456","dafinau","dafina123"),
            new Klienti("Filan","Fisteku","filan.fisteku@riinvest.net","44123454","filani","filani123")};

        //Menu-ja kryesore
        public void Home()
        {
            Console.WriteLine("Agjensionin turistik'Riinvest' \n\n");
            Console.WriteLine("Shtyp: \n 1)Per tu kyqur ne llogarine tuaj \n 2)Per tu kyqur si mysafir \n 3)Per tu regjistruar");
            int kyqu = int.Parse(Console.ReadLine());
            switch (kyqu)
            {
                case 1:
                    Kyqu();
                    break;
                case 2:
                    MenuMysafir();
                    break;
                case 3:
                    Regjistrohu();
                    break;
            }
            Console.Clear();
        }

        //regjistrimi i perdoruesve
        void Regjistrohu()
        {
            Console.WriteLine("Miresevini ne agjensionin turistik'Riinvest' \n\n");
            Perdoruesit.Add(new Klienti("", "", "", "","", ""));
            Console.Clear();
            Menu();
        }

        //kyqja nepermjet nje llogarie ekzistuese
        void Kyqu()
        {
            Console.WriteLine("Miresevini ne agjensionin turistik'Riinvest' \n\n");
            Console.Write("Shtypeni emrin e perdoruesit: ");
            string username = Console.ReadLine();
            Console.Write("Shtypeni fjalekalimin tuaj: ");
            string password = Console.ReadLine();

            foreach (var item in Perdoruesit)
            {
                if (item.Username == username && item.Password == password)
                {
                    Console.Clear();
                    Console.WriteLine($"Miresevini {item.Emri} {item.Mbiemri}");
                    Menu();
                }

            }
         
                Console.WriteLine("Provoni perseri");
                Kyqu();
            
        }

        //kyqja si mysafir
         void MenuMysafir()
        {

        }

        //sherbimet pas kyqjes 
        void Menu()
        {
            Console.WriteLine("Miresevini ne agjensionin turistik'Riinvest' \n\n\n");
            Console.WriteLine("Shtyp: \n 1)Per te rezervuar nje bilete \n2)Per te anuluar nje bilete \n3)Per te shfaq te gjitha biletat \n4)Per te shfaq te gjitha ofertat \n5)Per tu qkyqur");
            int sherbimi = Convert.ToInt32(Console.ReadLine());
            switch (sherbimi)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:Home();
                    break;
            }

        }

        
    }
}
