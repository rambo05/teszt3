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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ablakv
{
    /// <summary>
    /// Interaction logic for old2.xaml
    /// </summary>
    public partial class old2 : Page
    {
        public old2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new old1());
        }

        private void Bevi_Click(object sender, RoutedEventArgs e)
        {
            string a = nv.Text;
            string b = nm.Text;
            string c = ada.Text;
            string d = a + ";" + b + ";" + c;

            Skuel uj = new Skuel();
            uj.Regiz(a, b, c);

            MessageBox.Show("Sikeres felvétel!");            
        }
    }
}
