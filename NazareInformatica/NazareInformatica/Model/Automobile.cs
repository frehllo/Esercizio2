using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NazareInformatica.Model
{
    internal class Automobile:VeicoloSuRuote
    {
        public override string ToString()
        {
            return $"Quest'auto ha {NumeroRuote} ruote  il modello {Modello} e di colore {Colore}";
        }

        public Automobile()
        {

        }
        public Automobile(string modello, string colore)
        {
            this.Modello = modello;
            this.Colore = colore;
        }
        public override int NumeroRuote
        {
            get { return 4; }
        }
    }
}
