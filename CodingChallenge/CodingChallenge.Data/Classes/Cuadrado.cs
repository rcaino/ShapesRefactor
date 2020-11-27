using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : PoligonoRegular
    {
        public Cuadrado(decimal _longitud):base(4,_longitud){
        }

        public override string Tipo => "Square";

        public override decimal CalcularArea()
        {
            return longitud * longitud;
        }
    }
}
