using ProjektWzorce.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWzorce.Models
{
    public class Customer : Interfaces.IObserver<Offer>
    {
        private readonly Logger _logger;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Customer() { _logger = Logger.GetInstance(); }

        public void Update(Offer observable, string value)
        {
            _logger.LogMessage("Wysłano powiadomienie do: " + FirstName + " " + LastName);
            Console.WriteLine("Oferta nr: " + observable.Id + ". Zmieniła się cena samochodu " + observable.Model + ", który obserwujesz. Nowa cena: " + value + " zł");
        }

    }
}
