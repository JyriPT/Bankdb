using System;
using BankDB.Data;
using BankDB.Views;

namespace BankDB
{
    class Program
    {
        static private readonly BankdbContext context = new BankdbContext();
        static private readonly IBankView _bankView = new BankView();

        static void Main(string[] args)
        {

            string choice = null;

            string msg = "";
            do
            {
                choice = UserInterface();

                switch (choice.ToUpper())
                {
                    case "C":

                        _bankView.CreateBank();
                        msg = "\n----------------------------> \nPaina Enter jatkaaksesi!";
                        break;
                    default:
                        msg = "Nyt tuli huti yritä uudestaan - Paina Enter ja aloita alusta!";
                        break;
                }

                Console.WriteLine(msg);
                Console.ReadLine();
                Console.Clear();
            }
            while (choice.ToUpper() != "X");

        }

        static string UserInterface()
        {
            Console.WriteLine("Tietokannan käsittely esimerkki!");
            Console.WriteLine("[C] Lisää tietokantaan uusi tietue");
            Console.WriteLine("[R] Lue kaiki tietokannan tiedot");
            Console.WriteLine("[U] Päivitä henkilön tiedot");
            Console.WriteLine("[D] Poista henkilö tietokannasta");
            Console.WriteLine("[R1] Etsi henkilö Id:n persuteella");
            Console.WriteLine("[X] Lopeta ohjelmansuoritus");
            Console.WriteLine();
            Console.Write("Valitse mitä tehdään: ");

            return Console.ReadLine();
        }
        
    }
}
