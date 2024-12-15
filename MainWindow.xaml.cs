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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            KayıtListele2 ff = new KayıtListele2();
            ff.Show();
        }

   
        private void KAYIT_LİSTELE__Click(object sender, RoutedEventArgs e)
        {
            KayıtListele2 ff = new KayıtListele2();
            ff.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            YeniKayıt ff = new YeniKayıt();
            ff.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TedarikçiEkle ff = new TedarikçiEkle();
            ff.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TedarikçiListele ff = new TedarikçiListele();
            ff.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Tedarikçi_Borç_Ekle ff = new Tedarikçi_Borç_Ekle();
            ff.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TedarikçiBorçListesi ff = new TedarikçiBorçListesi();
            ff.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ürünekle ff = new ürünekle();
            ff.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ürünlistele ff = new ürünlistele();
            ff.Show();
        }
    }
}
