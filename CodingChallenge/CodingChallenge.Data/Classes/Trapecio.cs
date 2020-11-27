using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : IFormaGeometrica
    {
        public string Tipo => "Trapeze";
        private decimal baseMayor;
        private decimal baseMenor;
        private decimal altura;

        public Trapecio(decimal _baseMayor, decimal _baseMenor, decimal _altura)
        {

        }

        public decimal CalcularArea() => (baseMayor + baseMenor) * altura / 2;

        public decimal CalcularPerimetro()
        {
            return 5;
        }
    }
}
