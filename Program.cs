using ProjektWzorce.Abstracts;
using ProjektWzorce.Interfaces;
using ProjektWzorce.Models;
using ProjektWzorce.Utilities;
using System;

namespace ProjektWzorce
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger _logger = Logger.GetInstance();

            // ----------- CREATE CUSTOMERS ---------------
            Customer customer1 = new()
            {
                FirstName = "Jan",
                LastName = "Nowak",
                Email = "test@test.pl"
            };

            Customer customer2 = new()
            {
                FirstName = "Tadeusz",
                LastName = "Kowalski",
                Email = "test2@test.pl"
            };



            // ------------- OPEL ASTRA --------------------
            CarFactory astraCarFactory = new AstraFactory();
            IOpel opelAstra = astraCarFactory.CreateOpel("niebieski");       
            opelAstra = new PackageComfort(opelAstra);
            opelAstra = new PackageSport(opelAstra);

            Offer astraOffer = new()
            {
                Id = 1,
                Model = opelAstra.GetModel(),
                Color = opelAstra.GetColor(),
                Accessories = opelAstra.GetAccessories(),
                PackageName = opelAstra.GetPackageNames(),
                Price = opelAstra.GetPrice(),
                Sold = false
            };



            // ------------- OPEL CORSA --------------------
            CarFactory corsaCarFactory = new CorsaFactory();
            IOpel opelCorsa = corsaCarFactory.CreateOpel("biały");
            opelCorsa = new PackageSport(opelCorsa);
            opelCorsa = new PackageSecurity(opelCorsa);

            Offer corsaOffer = new()
            {
                Id = 2,
                Model = opelCorsa.GetModel(),
                Color = opelCorsa.GetColor(),
                Accessories = opelCorsa.GetAccessories(),
                PackageName = opelCorsa.GetPackageNames(),
                Price = opelCorsa.GetPrice(),
                Sold = false
            };



            // ---------- CREATE COLLECTION ----------------
            OfferCollection collection = new();
            collection.Add(astraOffer);
            collection.Add(corsaOffer);

            IOfferIterator<Offer> iterator = collection.Iterator();
            while (iterator.HasNext()) { Console.WriteLine(iterator.Next()); }



            // ----------- SUBSCRIBE OFFERS ----------------         
            astraOffer.Subscribe(customer1);
            astraOffer.Subscribe(customer2);
            corsaOffer.Subscribe(customer2);

            

            // ------ MODIFY PRICE AND STATUS --------------          
            astraOffer.Price -= 4000;
            corsaOffer.Price -= 6000;
            corsaOffer.Sold = true;



            // ------- UNSUBSCRIBE OFFERS ------------------
            astraOffer.Unsubscribe(customer1);



            // ------------- MODIFY PRICE  -----------------          
            astraOffer.Price += 2000;
        }
    }
}
