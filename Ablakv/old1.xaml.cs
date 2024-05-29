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
    /// Interaction logic for old1.xaml
    /// </summary>
    public partial class old1 : Page
    {
        public old1()
        {
            InitializeComponent();
        }

        private void Tov_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new old2());
        }

        private void Ker_Click(object sender, RoutedEventArgs e)
        {
            string k = ke.Text;
            Skuel uj = new Skuel();
            string[] s=uj.Keres(k);
            k ="";
            for (int i = 0; i < s.Length; i++)
            {
                k = k+s[i] + "\n";
            }
            lista.Text = k;
        }

        
    }
}
