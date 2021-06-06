using ProjektWzorce.Abstracts;
using ProjektWzorce.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWzorce.Models
{
    public class AstraFactory : CarFactory
    {
        public override IOpel CreateOpel(string color) => new Astra(color); 
    }
}
