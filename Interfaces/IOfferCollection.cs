using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWzorce.Interfaces
{
    public interface IOfferCollection<T>
    {
        void Add(T element);
        void Remove(T element);
        IOfferIterator<T> Iterator();
    }
}
