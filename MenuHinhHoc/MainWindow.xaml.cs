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

namespace MenuHinhHoc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bankinh.IsEnabled = false;
            ht.IsEnabled = false;
            canh.IsEnabled = false;
            hv.IsEnabled = false;
            lishhv.Items.Add("Cạnh" + "   " + "Diện Tích");
            lishht.Items.Add("Bán Kính      " + "Diện Tích");
        }

        private void Hinhvuong_Click(object sender, RoutedEventArgs e)
        {
            bankinh.IsEnabled = false;
            ht.IsEnabled = false;
            canh.IsEnabled = true;
            hv.IsEnabled = true; 
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Hinhtron_Click(object sender, RoutedEventArgs e)
        {
            bankinh.IsEnabled = true;
            ht.IsEnabled = true;
            canh.IsEnabled = false;
            hv.IsEnabled = false;
        }

        private void Hv_Click(object sender, RoutedEventArgs e)
        {
            double s;
                s = Math.Pow(Double.Parse(canh.Text), 2);

            lishhv.Items.Add(canh.Text + "\t" + s.ToString());   
        }

        private void Ht_Click(object sender, RoutedEventArgs e)
        {
            double s;
            s = 2 * 3.14 * Math.Pow(Double.Parse(bankinh.Text), 2);

            lishht.Items.Add(bankinh.Text + "\t     " + s.ToString()); 
        }
    }
}
