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
using Notatnik.Logic;
namespace Notatnik
{
    /// <summary>
    /// Interaction logic for Notatka.xaml
    /// </summary>
    public partial class Notatka : Window
    {
        public Notatka()
        {
            InitializeComponent();
        }
        public void Ustaw(Logic.INote x)
        {
            wyswietlone.UstawTekst(x.Tekst());
            wyswietlone.UstawTytul(x.Tytul());
            wyswietlone.UstawDate(x.DataStworzenia());
        }
    }
}
