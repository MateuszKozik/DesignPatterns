using ProjektWzorce.Interfaces;
using ProjektWzorce.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWzorce.Models
{
    public class Astra : IOpel
    {
        private readonly Logger _logger;
        public string Model { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string PackageName { get; set; }
        public List<Accessory> Accessories { get; set; }

        public Astra(string color)
        {
            _logger = Logger.GetInstance();

            Model = "Opel Astra";
            Color = color;
            PackageName = "Wyposażenie standardowe";

            Accessories = new()
            {
                 new Accessory { Name = "1.2 Turbo 81 kW / 110 KM", Price = 49800 },
                 new Accessory { Name = "Czujnik deszczu", Price = 2200 },
                 new Accessory { Name = "Oświetlenie bagażnika", Price = 3100 },
                 new Accessory { Name = "Gniazdo USB", Price = 1600 },
                 new Accessory { Name = "Elektryczne szyby", Price = 1800 },
                 new Accessory { Name = "Klimatyzacja", Price = 2400 },
                 new Accessory { Name = "System Start&Stop", Price = 4400 },
                 new Accessory { Name = "Multimedia", Price = 2100 },
                 new Accessory { Name = "Zaczepy Isofix", Price = 1800 },
            };

            Accessories.ForEach(accessory => Price += accessory.Price);

            _logger.LogMessage("Utworzono nowy samochód: " + Model + " w kolorze: " + Color + ". Cena: " + Price + " zł.");
        }

        public double GetPrice() => Price;
        public List<Accessory> GetAccessories() => Accessories;
        public string GetModel() => Model;
        public string GetColor() => Color;
        public string GetPackageNames() => PackageName;
    }
}
