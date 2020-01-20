using _4BIAndreiNazareInterfacce.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BIAndreiNazareInterfacce
{
    class Persona
    {
        public void AscoltaSuono(IFonteSonora oggettoCheSuona)
        {
            Console.WriteLine("Sto ascoltando:" + oggettoCheSuona.Emmettisuono());
        }
    }
}
