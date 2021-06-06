using ProjektWzorce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWzorce.Interfaces
{
    public interface IOpel
    {
        double GetPrice();
        List<Accessory> GetAccessories();
        string GetModel();
        string GetColor();
        string GetPackageNames();
    }
}
