using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BIAndreiNazareInterfacce
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();

            Gatto g = new Gatto();
            p.AscoltaSuono(g);

            Lavatrice l = new Lavatrice();
            p.AscoltaSuono(l);
        }
    }
}
