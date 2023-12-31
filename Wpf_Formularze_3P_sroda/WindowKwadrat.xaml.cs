﻿using System;
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
    /// Logika interakcji dla klasy WindowKwadrat.xaml
    /// </summary>
    public partial class WindowKwadrat : Window
    {
        public WindowKwadrat()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String wpisanyBok = bok_txt.Text;
            kwadrat.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(kolorki.Text);
            if(przezrocz_chbox.IsChecked == true) {
                kwadrat.Opacity = 0.5;
            }
            else
            {
                kwadrat.Opacity = 1;
            }
            if(widoczny.IsChecked == true)
            {
                kwadrat.Visibility = Visibility.Visible;
            }
            if(ukryty.IsChecked == true)
            {
                kwadrat.Visibility = Visibility.Hidden;
            }
            double bok;
            MessageBox.Show("Wpisano: " + wpisanyBok, "Wartość wpisana",
                MessageBoxButton.OK, MessageBoxImage.Information);
            if(double.TryParse(wpisanyBok, out  bok) ) 
            {
                double pole = bok * bok;
                wynik_pole_txt.Text = pole.ToString();
                double obwod = 4 * bok;
                wynik_obwod_txt.Text = obwod.ToString();

                kwadrat.Width = bok;
                kwadrat.Height = bok;


            }
            else
            {
                MessageBox.Show("Musisz wpisać liczbę rzeczywistą");
                wynik_obwod_txt.Text = "";
                wynik_pole_txt.Text = string.Empty;
            }
        }

        private void bok_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(double.TryParse(bok_txt.Text,out double boczek))
            {
                kwadrat.Width = boczek * 2;
                kwadrat.Height = boczek * 2;
                
            }
        }
    }
}
