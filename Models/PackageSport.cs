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
    public class PackageSport : OptionalAccessories
    {
        private readonly Logger _logger;

        public double Price { get; set; }
        public string PackageName { get; set; }
        public List<Accessory> Accessories { get; set; }
        public PackageSport(IOpel opel) : base(opel)
        {
            _logger = Logger.GetInstance();

            PackageName = "Pakiet sport";
            Accessories = new()
            {
                new Accessory { Name = "Przyciemniane szyby z tyłu", Price = 1500 },
                new Accessory { Name = "Koła aluminiowe 17\",4 ramienne", Price = 3250 }
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
