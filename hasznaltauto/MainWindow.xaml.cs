﻿using System.Diagnostics.Metrics;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
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


namespace hasznaltauto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Car> kocsik = new();
        public MainWindow()
        {
            InitializeComponent();
            var adatok = File.ReadAllLines(@"..\..\..\src\forras.txt");
            foreach (var item in adatok)
            {
                var sor = item.Split("; ");
                string nev = sor[0];
                string tip = sor[1];
                string uz = sor[2];
                int ev = int.Parse(sor[3]);
                string kep = sor[4];

                kocsik.Add(new Car(nev, tip, uz, ev, kep));
            }

            foreach (var item in kocsik)
            {
                kocsikLista.Items.Add(item.Nev);
            }

            kocsikLista.SelectionChanged += change;


        }
        private void change(object sender, SelectionChangedEventArgs e)
        {
            if (kocsikLista.SelectedItem != null)
            {
                int index = kocsikLista.SelectedIndex;
                NevLabel.Content = kocsik[index].Nev;
               
                TipusLabel.Content = kocsik[index].Tipus;
                uzemanyagLabel.Content = kocsik[index].Uzemanyag;
                EvLabel.Content = kocsik[index].Ev;


                Image finalImage = new();
                string currentDirectory = Directory.GetCurrentDirectory();
                finalImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(currentDirectory, $@"..\imges\{kocsik[index].Kep}")));

                images.Children.Clear();
                images.Children.Add(finalImage);

            }
        }

    

        private void torles_Click_1(object sender, RoutedEventArgs e)
        {
            if (kocsikLista.SelectedItem != null)
            {
                int index = kocsikLista.SelectedIndex;
                kocsikLista.Items.RemoveAt(index);

                kocsik.Remove(kocsik[index]);

                string s = string.Empty;
                NevLabel.Content = s;
                TipusLabel.Content = s;
                uzemanyagLabel.Content = s;
                EvLabel.Content = s;
                images.Children.Clear();
            }
           

        }
    }
}