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
using System.IO;

namespace Natale3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmb_operazioni.Items.Add("Somma");
            cmb_operazioni.Items.Add("Differenza");
            cmb_operazioni.Items.Add("Moltiplicazione");
            cmb_operazioni.Items.Add("Divisione");
        }

        string file = "risultati.txt";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double n1 = double.Parse(txt_n1.Text);
            double n2 = double.Parse(txt_n2.Text);
            double ris;
            if (cmb_operazioni.SelectedIndex == 0)
            {
                ris = n1 + n2;
                lbl_ris.Content = $"Il risultato è {ris}";
            }
            if (cmb_operazioni.SelectedIndex == 1)
            {
                ris = n1 - n2;
                lbl_ris.Content = $"Il risultato è {ris}";
            }
            if (cmb_operazioni.SelectedIndex == 2)
            {
                ris = n1 * n2;
                lbl_ris.Content = $"Il risultato è {ris}";
            }
            if (cmb_operazioni.SelectedIndex == 3)
            {
                ris = n1 / n2;
                lbl_ris.Content = $"Il risultato è {ris}";
            }
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine(lbl_ris.Content);
            }
        }
    }
}
