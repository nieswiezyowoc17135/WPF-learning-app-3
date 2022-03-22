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

namespace WPF_learning_app_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private String przedmiot_zamowienia = "Przedmiot zamówienia: ";
        private String cena_przed_rabatem = "Cena przed rabatem: ";
        private String naliczony_rabat = "Naliczony rabat: ";
        private String cena_po_rabacie = "Cena po rabacie: ";

        private double final_price = 0;
        private double A0_price = 0.20;

        public MainWindow()
        {
            InitializeComponent();
        }

        //zamykanie okienka za pomoca przycisku anuluj
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //zmienianie zawartosci labela w czasie rzeczywsitym
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBoxOutput.Text = przedmiot_zamowienia + TextBoxInput.Text + " szt," + slider1.Value;
        }

        //label pokazujacy, ktory format i cene wybralismy
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label_slider.Content = "A" + slider1.Value.ToString() + " - cena " + (final_price = price(slider1.Value)) + "zl/szt";
        }

        //metoda obliczajaca cene za poszczegolny format wydruku
        private double price(double position)
        {
            if (position == 0)
            {
                return A0_price;
            }
            if (position == 1)
            {
                return A0_price * 2.5;
            }
            if (position == 2)
            {
                return A0_price * 2.5 * 2.5;
            }
            if (position == 3)
            {
                return Math.Round(A0_price * 2.5 * 2.5 * 2.5, 2, MidpointRounding.AwayFromZero);
            }
            if (position == 4)
            {
                return Math.Round(A0_price * 2.5 * 2.5 * 2.5 * 2.5, 2, MidpointRounding.AwayFromZero);
            }
            if (position == 5)
            {
                return Math.Round(A0_price * 2.5 * 2.5 * 2.5 * 2.5 * 2.5, 2,MidpointRounding.AwayFromZero);
            }
            else
            {
                return 0;
            }
        }
    }
}
