using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Notatnik.Logic;

namespace Notatnik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PobierzNotatki();
        }

        private void PobierzNotatki()
        {
            notatki.ItemsSource = Logic.DB.PobierzNotatki();
        }

        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            if (tytul.Text != "" && tekst.Text != "")
            {
                var ty = tytul.Text;
                var te = tekst.Text;
                Thread t = new Thread(() =>
                {
                    Logic.DB.DodajDoBazy(ty, te);
                });
                t.Start();
                
                PobierzNotatki();
            }
        }

        private void Wyswietl_Click(object sender, RoutedEventArgs e)
        {

            var wybrana = (INote)notatki.SelectedItem;
            Notatka okno = new Notatka();
            okno.Ustaw(wybrana);
            okno.Show();
            
        }
    }
}
