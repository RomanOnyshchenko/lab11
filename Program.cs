using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter voyage city");
            string travel = Console.ReadLine();

            MorningVoyage MorningVoyage = new MorningVoyage();
            AfternoonVoyage AfternoonVoyage = new AfternoonVoyage();
            EveningVoyage EveningVoyage = new EveningVoyage();

            BusStation ticket = new BusStation(MorningVoyage, AfternoonVoyage, EveningVoyage);

            Customer Customer = new Customer();
            Customer.CreateOrder(ticket);
            
            Console.Read();
        }
    }


    class MorningVoyage
    {
        public void MorningTicket()
        {
            Console.WriteLine("Bus leaves at 9:30am");
        }
    }
    class AfternoonVoyage
    {
        public void AfternoonTicket()
        {
            Console.WriteLine("Bus leaves at 3:30pm");
        }
    }
    class EveningVoyage
    {
        public void EveningTicket()
        {
            Console.WriteLine("Bus leaves at 8:20pm");
        }
        public void Finish()
        {
            Console.WriteLine("All possible variants were shown");
        }
    }
 
    class BusStation
    {
        MorningVoyage MorningVoyage;
        AfternoonVoyage AfternoonVoyage;
        EveningVoyage EveningVoyage;
        public BusStation(MorningVoyage morning, AfternoonVoyage afternoon, EveningVoyage evening)
        {
            this.MorningVoyage = morning;
            this.AfternoonVoyage = afternoon;
            this.EveningVoyage = evening;
        }
        public void Start()
        {
            MorningVoyage.MorningTicket();
            AfternoonVoyage.AfternoonTicket();
            EveningVoyage.EveningTicket();
        }
        public void Stop()
        {
            EveningVoyage.Finish();
        }
    }
 
    class Customer
    {
        public void CreateOrder(BusStation facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}