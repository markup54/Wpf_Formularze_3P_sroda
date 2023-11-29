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

namespace Wpf_Formularze_3P_sroda
{
    /// <summary>
    /// Logika interakcji dla klasy WindowKalkulator.xaml
    /// </summary>
    public partial class WindowKalkulator : Window
    {
        public WindowKalkulator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(liczba1.Text, out int a) && int.TryParse(liczba2.Text,out int b) )
            {
                int w = a + b;
                wynik_label.Content ="Wynik dodawania:"+  w;
            }
        }
    }
}
