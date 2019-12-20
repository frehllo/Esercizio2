using System;
using System.Collections.Generic;
using System.IO;
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

namespace AppMerende
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Merenda> Merende = new List<Merenda>();

        public MainWindow()
        {
            InitializeComponent();
        }
        public void CaricaMerende()
        {

            string line;
            StreamReader sr = new StreamReader("merendeexcel.csv");
            sr.ReadLine();
            while ((line = sr.ReadLine()) != null)
            {
                try
                {
                    //Creo una istanza 
                    Merenda m = new Merenda();
                    //Vettore
                    string[] campi = line.Split(';');
                    m.Nome = campi[0];
                    double Prezzo = Convert.ToDouble(campi[1]);
                    m.Prezzo = Prezzo;
                    Merende.Add(m);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    break;
                }

                
            }

            foreach (Merenda m in Merende)
            {
                lst_merendinedisponibili.Items.Add(m);
            }
        }

        private void btn_carica_Click_1(object sender, RoutedEventArgs e)
        {
            CaricaMerende();
            //Task.Factory.StartNew(CaricaMerende); 
        }
    }
}
