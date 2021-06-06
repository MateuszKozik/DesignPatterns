using ProjektWzorce.Interfaces;
using ProjektWzorce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWzorce.Abstracts
{
    public abstract class OptionalAccessories : IOpel    
    {
        private readonly IOpel _opel;
        public OptionalAccessories(IOpel opel) { _opel = opel; }

        public virtual List<Accessory> GetAccessories() => _opel.GetAccessories();
        public virtual string GetModel() => _opel.GetModel();
        public virtual string GetColor() => _opel.GetColor();
        public virtual double GetPrice() => _opel.GetPrice();
        public virtual string GetPackageNames() => _opel.GetPackageNames();
    }
}
