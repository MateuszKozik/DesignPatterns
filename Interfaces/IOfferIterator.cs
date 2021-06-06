using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWzorce.Interfaces
{
    public interface IOfferIterator <T>
    {
        bool HasNext();
        string Next();
    }
}
