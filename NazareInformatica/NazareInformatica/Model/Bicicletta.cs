using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NazareInformatica.Model
{
    class Bicicletta:VeicoloSuRuote
    {
        public override int NumeroRuote
        {
            get { return 2; }
        }

        public string TipoDiBici { get; set; }
    }
}
