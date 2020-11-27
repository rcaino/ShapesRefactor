using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : PoligonoRegular
    {
        public override string Tipo => "Triangle";
        public TrianguloEquilatero(decimal _longitud) : base(3, _longitud) { }

        public override decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * longitud * longitud;
    }
}
