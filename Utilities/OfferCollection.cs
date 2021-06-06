using ProjektWzorce.Interfaces;
using ProjektWzorce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWzorce.Utilities
{
    public class OfferCollection : IOfferCollection<Offer>
    {
        private readonly List<Offer> offers = new();

        public void Add(Offer offer) { offers.Add(offer); }
        public void Remove(Offer offer) { offers.Remove(offer); }
        public IOfferIterator<Offer> Iterator() { return new OfferIterator(offers); }
    }
}
