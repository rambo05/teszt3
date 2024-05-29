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

namespace Ablakv
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void Lo_Click(object sender, RoutedEventArgs e)
        {
            string a = nv.Text;
            string b = ada.Text;
            string c=a+";"+b;
            Skuel uj = new Skuel();
            bool v=uj.Logi(c);
            if (v)
            {
                MessageBox.Show("Sikeres belépés!");
                ab1 ablak = new ab1();
                ablak.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Hibás, vagy nem létező felhasználó!");
                nv.Clear();
                ada.Clear();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
