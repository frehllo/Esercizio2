using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile auto1 = new Automobile("audi", "a4","170");
            Automobile auto2 = new Automobile("audi", "a4","130");
            Console.WriteLine(auto1);
            Console.WriteLine(auto2);
            if (auto1.Equals(auto2))
            {
                Console.WriteLine("Sono uguali");
            }
            else
            {
                Console.WriteLine("Sono diversi");
            }
            Console.ReadLine();
        }
    
    }
}
