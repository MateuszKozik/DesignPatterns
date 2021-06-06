using ProjektWzorce.Interfaces;
using ProjektWzorce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWzorce.Utilities
{
    public class OfferIterator : IOfferIterator<Offer>
    {
        private readonly List<Offer> offers;
        private int index;

        public OfferIterator(List<Offer> offers) { this.offers = offers; }

        public bool HasNext() { return index < offers.Count; }

        public String Next()
        {
            Offer offer = offers.ElementAt(index++);
            if (offer.Accessories != null) { aIndex = 0; accessories = offer.Accessories; }

            StringBuilder sb = new();
            sb.AppendLine("Oferta nr: " + offer.Id);
            sb.AppendLine("Model: " + offer.Model);
            sb.AppendLine("Kolor: " + offer.Color);
            sb.AppendLine("Cena: " + offer.Price + " zł");
            sb.AppendLine("Status: " + (offer.Sold ? "Sprzedany" : "Dostępny"));
            sb.AppendLine("Pakiety wyposażenia: " + offer.PackageName);
            sb.Append("Wyposażenie: ");
            while (HasNextAccessory()) { sb.Append(NextAccessory()); }
            sb.AppendLine();
            return sb.ToString();
        }



        private List<Accessory> accessories;
        private int aIndex;
        private bool HasNextAccessory() { return aIndex < accessories.Count; }
        private string NextAccessory()
        {
            Accessory accessory = accessories.ElementAt(aIndex++);
            StringBuilder sb = new();
            return sb.Append(accessory.Name + ", ").ToString();
        }

    }
}
