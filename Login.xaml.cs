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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (txtUser.Text.ToLower() == "admin" && txtPassword.Password == "admin")
            {
                MainWindow admin = (MainWindow)Window.GetWindow(this);
                admin.frameMain.NavigationService.Navigate(new admin());
            }
            else if (txtUser.Text.ToLower() == "empleado" && txtPassword.Password == "empleado"
            {
                MainWindow empleado = (MainWindow)Window.GetWindow(this);
                empleado.frameMain.NavigationService.Navigate(new empleado());

            }
            else
                MessageBox.Show("Credenciales incorrectas");
        }
    }
}
