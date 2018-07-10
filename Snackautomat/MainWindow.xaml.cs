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
    public partial class MainWindow : Window
    {
        vmMainWindow vmMainWindow;

        public MainWindow()
        {
            InitializeComponent();
            vmMainWindow = new vmMainWindow();
            DataContext = vmMainWindow;
        }

        private void abbrechenbtn_Click(object sender, RoutedEventArgs e)
        {
            vmMainWindow.Abbrechen();
        }

        private void kaufenBtn_Click(object sender, RoutedEventArgs e)
        {
            vmMainWindow.Kaufen();
        }
    }
}
