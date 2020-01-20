using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uguaglianza
{
    class PuntoDelPiano
    {
        public int X { get; set; }

        public int Y { get; set; }

        public PuntoDelPiano(int x, int y)
        {
            this.X = x;                               
            this.Y = y;

        }
        public override bool Equals(object obj)
        {
            PuntoDelPiano punto2 = obj as PuntoDelPiano;
            if(punto2!= null)
            {
                return this.X == punto2.X && this.Y == punto2.Y; 
                    
            }
            else
            {
                return false;
            }
            
        }
        public override string ToString()
        {
            return $"({X};{Y})";
            
        }
    }
}
