using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void IngresosClick(object sender, RoutedEventArgs e)
        {
            Registro menu = new Registro();
            menu.Show();
            Close();

        }
        private void SalidaClick(object sender, RoutedEventArgs e)
        {


        }
        private void ConductoresClick (object sender, RoutedEventArgs e)
        {


        }
        private void CamionesClick (object sender, RoutedEventArgs e)
        {


        }
        private void TransportistasClick(object sender, RoutedEventArgs e)
        {


        }
        private void ProductosClick(object sender, RoutedEventArgs e)
        {


        }
        private void CargasClick(object sender, RoutedEventArgs e)
        {


        }
        private void IngresosReporteClick(object sender, RoutedEventArgs e)
        {


        }
        private void SalidasReporteClick(object sender, RoutedEventArgs e)
        {


        }
    }
}
