using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackautomat
{
    public class Model
    {
        private List<Produkt> produktPool;
        public List<Produkt> ProduktPool
        {
            get { return produktPool; }
            set { produktPool = value; }
        }
        private List<Geld> geldPool;
        public List<Geld> GeldPool
        {
            get { return geldPool; }
            set { geldPool = value; }
        }
        public Model()
        {
            ProduktPool = new List<Produkt>();
            GeldPool = new List<Geld>();

            ProduktPool.Add(new Produkt(0, "Cola", Settings.PRODUKTBILDPFAD + "cola.jpg", 0.75));
            ProduktPool.Add(new Produkt(1, "Fanta", Settings.PRODUKTBILDPFAD + "fanta.jpg", 0.75));
            ProduktPool.Add(new Produkt(2, "Sprite", Settings.PRODUKTBILDPFAD + "sprite.jpg", 0.75));
            ProduktPool.Add(new Produkt(3, "Snickers", Settings.PRODUKTBILDPFAD + "snickers.jpg", 1.20));

            ProduktPool.Add(new Produkt(4, "Balisto", Settings.PRODUKTBILDPFAD + "balisto.jpg", 1.20));
            ProduktPool.Add(new Produkt(5, "Bounty", Settings.PRODUKTBILDPFAD + "bounty.jpg", 1.20));
            ProduktPool.Add(new Produkt(6, "FunnyFrisch", Settings.PRODUKTBILDPFAD + "funnyfresh.jpg", 1.20));
            ProduktPool.Add(new Produkt(7, "KitKat", Settings.PRODUKTBILDPFAD + "kitkat.jpg", 1.20));
            ProduktPool.Add(new Produkt(9, "Milkyway", Settings.PRODUKTBILDPFAD + "milkyway.jpg", 1.20));
            ProduktPool.Add(new Produkt(10, "Twix", Settings.PRODUKTBILDPFAD + "twix.png", 1.20));
            ProduktPool.Add(new Produkt(11, "Ülker", Settings.PRODUKTBILDPFAD + "uelker.jpg", 1.20));
        }
    }
}
