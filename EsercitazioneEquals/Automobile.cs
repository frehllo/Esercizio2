using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneEquals
{
    class Automobile
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public string Cilindrata { get; set; }
        public Automobile(string marca, string modello,string cilindrata)
        {
            this.Marca = marca;
            this.Modello = modello;
            this.Cilindrata = cilindrata;

        }
        public override bool Equals(object obj)
        {
            Automobile macchina1 = obj as Automobile;
            if (macchina1 != null)
            {
                return this.Marca == macchina1.Marca && this.Modello == macchina1.Modello;

            }
            else
            {
                return false;
            }

        }
        public override string ToString()
        {
            return $"({Marca};{Modello};{Cilindrata} )";

        }
    }
}
