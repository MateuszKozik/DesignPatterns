using ProjektWzorce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWzorce.Interfaces
{
    public interface IObservable<T>
    {
        void Subscribe(Customer observer);
        void Unsubscribe(Customer observer);
        void Notify(string value);
    }
}
