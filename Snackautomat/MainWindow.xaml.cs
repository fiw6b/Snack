using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Snackautomat
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<Produkt> produktPool;
        public List<Produkt> ProduktPool
        {
            get { return produktPool; }
            set { produktPool = value; }
        }
        private List<Geld> geldPool;
        public List<Geld> GeldtPool
        {
            get { return geldPool; }
            set { geldPool = value; }
        }
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
                ausgewaehltesProdukt.SelectedItemBackgroundColor = new SolidColorBrush(Colors.DarkBlue);
                OnPropertyChanged("AusgewaehltesProdukt");
                OnPropertyChanged("KaufMoeglich");
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

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            ProduktPool = new List<Produkt>();
            geldPool = new List<Geld>();

            Guthaben = 20;

            ProduktPool.Add(new Produkt(0, "Cola", Settings.PRODUKTBILDPFAD + "cola.jpg", 0.75));
            ProduktPool.Add(new Produkt(1, "Fanta", Settings.PRODUKTBILDPFAD + "fanta.jpg", 0.75));
            ProduktPool.Add(new Produkt(2, "Sprite", Settings.PRODUKTBILDPFAD + "sprite.jpg", 0.75));
            ProduktPool.Add(new Produkt(3, "Snickers", Settings.PRODUKTBILDPFAD + "snickers.jpg", 1.20));
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler tempHandler = PropertyChanged;
            if (tempHandler != null)
            {
                tempHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void abbrechenbtn_Click(object sender, RoutedEventArgs e)
        {
            Guthaben = 0;
        }

        private void kaufenBtn_Click(object sender, RoutedEventArgs e)
        {
            Guthaben -= AusgewaehltesProdukt.Preis;
            AusgewaehltesProdukt = null;
        }
    }
}
