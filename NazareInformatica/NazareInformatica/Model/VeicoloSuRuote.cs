using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NazareInformatica.Model
{
    public abstract class VeicoloSuRuote :Veicolo
    {
        public abstract int NumeroRuote { get; }
    }
}
