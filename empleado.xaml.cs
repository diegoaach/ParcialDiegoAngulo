using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parcial
{
    /// <summary>
    /// Lógica de interacción para empleado.xaml
    /// </summary>
    public partial class empleado : Page
    {
        public empleado()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtCliente.Text == null ^ txtCedula.Text == null)
            {
                MessageBox.Show("Registre los datos del cliente.");
            }
            else if(cantPanAli.Text == "0"
                && cantPanEsp.Text == "0"
                && cantPanNoAli.Text == "0" )
            {
                MessageBox.Show("Seleccione al menos un tipo de pan.");
            }
            else if (int.Parse(cantPanAli.Text) < 0 ^ int.Parse(cantPanNoAli.Text) < 0 ^ int.Parse(cantPanEsp.Text) < 0)
            {
                MessageBox.Show("Ingrese valores validos.");
            }

            else
            {
                lblHora.Content = DateTime.Now.ToString("hh:mm:ss tt");
                txbCliente.Text = "Nombre: "+txtCliente.Text;
                txbCedula.Text = "Cedula:  "+txtCedula.Text;

                txbPanAli.Text = "Pan Aliñado x " + cantPanAli.Text;
                txbPanNoALi.Text = "Pan no Aliñado x " + cantPanNoAli.Text;
                txbPanEsp.Text = "Pan Especial x " + cantPanEsp.Text;

                int nPanAli = int.Parse(cantPanAli.Text);
                int nPanNoAli = int.Parse(cantPanNoAli.Text);
                int nPanEsp = int.Parse(cantPanEsp.Text);

                txbTotalCompra.Text = Convert.ToString((1000 * nPanAli) + (500 * nPanNoAli) + (2000 * nPanEsp))+"$";
            }

            txtCliente.Text = "";
            txtCedula.Text = "";
            cantPanAli.Text = "0";
            cantPanNoAli.Text = "0";
            cantPanEsp.Text = "0";

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow empleado = (MainWindow)Window.GetWindow(this);
            empleado.frameMain.NavigationService.Navigate(new Login());
        }
    }
}
