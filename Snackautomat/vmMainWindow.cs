using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Snackautomat
{
    class vmMainWindow : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Model model; 

        private Produkt ausgewaehltesProdukt;
        public Produkt AusgewaehltesProdukt
        {
            get { return ausgewaehltesProdukt; }
            set 
            {
                if (AusgewaehltesProdukt != null)
                {
                    AusgewaehltesProdukt.SelectedItemBackgroundColor = new SolidColorBrush(Colors.White);
                }
                ausgewaehltesProdukt = value;
                if (value != null)
                {
                    ausgewaehltesProdukt.SelectedItemBackgroundColor = new SolidColorBrush(Colors.DarkBlue);
                }

                OnPropertyChanged("AusgewaehltesProdukt");
                OnPropertyChanged("KaufMoeglich");
                OnPropertyChanged("minus");
                OnPropertyChanged("GuthabenMinusPreis");
            }
        }
        private double guthaben;
        public double Guthaben
        {
            get { return guthaben; }
            set { guthaben = value; OnPropertyChanged("Guthaben"); }
        }
        public bool KaufMoeglich
        {
            get
            {
                bool value = false;
                if (AusgewaehltesProdukt != null)
                {
                    if (Guthaben > AusgewaehltesProdukt.Preis)
                    {
                        value = true;
                    }
                }
                return value;
            }
        }
        public string minus
        {
            get
            {
                if (AusgewaehltesProdukt != null)
                {
                    return "-";
                }
                return "";
            }
        }

        public string GuthabenMinusPreis
        {
            get
            {
                if (AusgewaehltesProdukt != null)
                {
                    return (Guthaben - AusgewaehltesProdukt.Preis).ToString();
                }
                return "";
            }
        }
        public List<Produkt> ProduktPool
        {
            get
            {
                return model.ProduktPool;
            }
        }
        public List<Geld> GeldPool
        {
            get
            {
                return model.GeldPool;
            }
        }
        public string KaufenButtonText { get { return "Kaufen"; } }
        public string AbbrechenButtonText { get { return "Abbrechen"; } }

        public vmMainWindow()
        {
            model = new Model();
            Guthaben = 20;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler tempHandler = PropertyChanged;
            if (tempHandler != null)
            {
                tempHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void Abbrechen()
        {
            Guthaben = 0;
        }

        public void Kaufen()
        {
            Guthaben -= AusgewaehltesProdukt.Preis;
            AusgewaehltesProdukt = null;
        }
    }
}
