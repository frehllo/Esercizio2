using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NazareInformatica.Model;

namespace NazareInformatica
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile a = new Automobile();

            a.Modello = "Ferrari";
            a.Colore = "Rosso";
            
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
