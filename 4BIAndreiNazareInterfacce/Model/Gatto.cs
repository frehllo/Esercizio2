using _4BIAndreiNazareInterfacce.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BIAndreiNazareInterfacce
{
    class Gatto : Animale, IFonteSonora
    {
        public string Emmettisuono()
        {
            return "miao";
        }
    }
}
