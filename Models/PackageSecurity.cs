using ProjektWzorce.Abstracts;
using ProjektWzorce.Interfaces;
using ProjektWzorce.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWzorce.Models
{
    class PackageSecurity : OptionalAccessories
    {
        private readonly Logger _logger;
        public double Price { get; set; }
        public string PackageName { get; set; }
        public List<Accessory> Accessories { get; set; }
        public PackageSecurity(IOpel opel) : base(opel)
        {
            _logger = Logger.GetInstance();

            PackageName = "Pakiet bezpieczeństwo";
            Accessories = new()
            {
                new Accessory { Name = "Panoramiczna kamera cofania", Price = 2400 },
                new Accessory { Name = "Czujniki parkowania z przodu", Price = 800 },
                new Accessory { Name = "Czujniki parkowania z tyłu", Price = 400 },
                new Accessory { Name = "Rozpoznawanie znaków drogowych", Price = 1600 },
            };

            Accessories.ForEach(accessory => Price += accessory.Price);

            _logger.LogMessage("Dodano pakiet wyposażenia: " + PackageName + " do: " + opel.GetModel());
        }

        public override double GetPrice()
        {
            return base.GetPrice() + Price;
        }


        public override List<Accessory> GetAccessories()
        {
            Accessories.AddRange(base.GetAccessories());
            return Accessories;
        }

        public override string GetPackageNames()
        {
            return base.GetPackageNames() + ", " + PackageName;
        }
    }
}
