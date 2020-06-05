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

namespace CustomControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class NotatkaZTytulem : UserControl
    {
        public NotatkaZTytulem()
        {
            InitializeComponent();
        }

        public void UstawTekst(string t)
        {
            tekst.Text = t;
        }

        public void UstawTytul(string t)
        {
            tytul.Text = t;
        }

        public void UstawDate(DateTime d)
        {
            data.Text = d.ToString();
        }
    }
}
