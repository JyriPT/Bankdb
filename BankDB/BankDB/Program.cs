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
                    case "BANK":
                        BankSelection();
                        msg = "Press enter to return to start.";
                        break;

                    case "X":
                        msg = "Shutting down...";
                        break;

                    default:
                        Console.WriteLine("Invalid selection, please try again.");
                        msg = "Press enter to retry.";
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
            Console.WriteLine("[BANK] Create/Update/Delete Bank");
            Console.WriteLine("[R] Lue kaiki tietokannan tiedot");
            Console.WriteLine("[U] Päivitä henkilön tiedot");
            Console.WriteLine("[D] Poista henkilö tietokannasta");
            Console.WriteLine("[R1] Etsi henkilö Id:n persuteella");
            Console.WriteLine("[X] Quit program");
            Console.WriteLine();
            Console.Write("Valitse mitä tehdään: ");

            return Console.ReadLine();
        }

        static void BankSelection()
        {
            string select = null;

            do
            {
                Console.WriteLine("Select function:");
                Console.WriteLine("[C] Create");
                Console.WriteLine("[U] Update");
                Console.WriteLine("[D] Delete");
                Console.WriteLine("[X] To cancel and return to main menu");

                select = Console.ReadLine();

                switch (select.ToUpper())
                {
                    case "C":
                        _bankView.CreateBank();
                        break;

                    case "U":
                        _bankView.UpdateBank();
                        break;

                    case "D":
                        _bankView.DeleteBank();
                        break;

                    case "X":
                        Console.WriteLine("Returning to main menu, press enter.");
                        break;

                    default:
                        Console.WriteLine("Invalid selection, please try again. [SELECTION]");
                        break;
                }
            } while (select.ToUpper() != "X");
        }


        
    }
}
