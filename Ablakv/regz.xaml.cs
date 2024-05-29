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
    /// Interaction logic for regz.xaml
    /// </summary>
    public partial class regz : Window
    {
        public regz()
        {
            InitializeComponent();
        }

        private void Regg_Click(object sender, RoutedEventArgs e)
        {
            string a = nv.Text;
            string b = nm.Text;
            string c = ada.Text;
            string d = a + ";" + b+";"+c;

            Skuel uj = new Skuel();
            uj.Regiz(a,b,c);
            
            MessageBox.Show("Sikeres regisztráció!");
            this.Close();            
           
        }
    }
}
