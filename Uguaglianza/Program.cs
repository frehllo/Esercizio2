using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uguaglianza
{
    class Program
    {
        static void Main(string[] args)
        {
            PuntoDelPiano p1 = new PuntoDelPiano(2, 4);
            PuntoDelPiano p2 = new PuntoDelPiano(2, 4);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            if (p1.Equals(p2))
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
