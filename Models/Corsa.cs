using ProjektWzorce.Interfaces;
using ProjektWzorce.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWzorce.Models
{
    public class Corsa : IOpel
    {
        private readonly Logger _logger;
        public string Model { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string PackageName { get; set; }
        public List<Accessory> Accessories { get; set; }

        public Corsa(string color)
        {
            _logger = Logger.GetInstance();

            Model = "Opel Corsa";
            Color = color;
            PackageName = "Wyposażenie standardowe";       
            Accessories = new()
            {
                 new Accessory { Name = "Silnik 1.2 55 kW / 75 KM", Price = 32800 },
                 new Accessory { Name = "Elektrycznie sterowane lusterka", Price = 200 },
                 new Accessory { Name = "Reflektory przednie halogenowe", Price = 2100 },
                 new Accessory { Name = "Światła tylne żarowe", Price = 600 },
                 new Accessory { Name = "Fotel kierowcy z regulacją", Price = 1800 },
                 new Accessory { Name = "Klimatyzacja", Price = 2400 },
                 new Accessory { Name = "System Start&Stop", Price = 4400 },
                 new Accessory { Name = "Multimedia", Price = 2100 },
                 new Accessory { Name = "Monitorowanie ciśnienia w oponach", Price = 1800 }, 
            };

            Accessories.ForEach(accessory => Price += accessory.Price);

            _logger.LogMessage("Utworzono nowy samochód: " + Model + " w kolorze: " + Color + ". Cena: " + Price + " zł.");
        }

        public double GetPrice() => Price;
        public List<Accessory> GetAccessories() => Accessories;
        public string GetModel() => Model;
        public string GetColor() => Color;
        public string GetPackageNames() => "Wyposażenie standardowe";
    }
}
