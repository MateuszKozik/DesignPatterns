using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWzorce.Models
{
    public class Offer : Interfaces.IObservable<Customer>
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string PackageName { get; set; }
        public bool Sold { get; set; }    
        public List<Accessory> Accessories { get; set; }
       
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                // Gdy zmienia się cena oferty
                if (value < price && Sold.Equals(false))
                {
                    Notify(value.ToString());
                }
                price = value;
            }
        }

        private readonly List<Customer> observers = new();
        public void Notify(string value)
        {
            observers.ForEach(observer => observer.Update(this, value));
        }

        public void Subscribe(Customer newObserver)
        {
            observers.Add(newObserver);
        }

        public void Unsubscribe(Customer observerToRemove)
        {
            observers.Remove(observerToRemove);
        }      
    }   
}
