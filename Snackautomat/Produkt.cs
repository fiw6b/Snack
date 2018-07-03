using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Snackautomat
{
    public class Produkt : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int id;
        private string name;
        private string bildPfad;
        private double preis;
        private Brush color;

        public int Id 
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string BildPfad
        {
            get { return bildPfad; }
            set { bildPfad = value; }
        }

        public double Preis
        {
            get { return preis; }
            set { preis = value; }
        }

        public Brush SelectedItemBackgroundColor
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged("SelectedItemBackgroundColor");
            }
        }

        public Produkt(int id, string name, string bildPfad, double preis)
        {
            Id = id;
            Name = name;
            BildPfad = bildPfad;
            Preis = preis;
        }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler tempHandler = PropertyChanged;
            if (tempHandler != null)
            {
                tempHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
