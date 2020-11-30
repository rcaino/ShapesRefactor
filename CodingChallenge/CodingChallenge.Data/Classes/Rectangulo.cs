using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : IFormaGeometrica
    {
        #region Propiedades
        public string Tipo => "Rectangle";
        private decimal ladoBase { get; }
        private decimal altura { get; }
        #endregion

        #region Metodos
        public Rectangulo(decimal _ladoBase, decimal _altura)
        {
            ladoBase = _ladoBase;
            altura = _altura;
        }

        public decimal CalcularArea() => ladoBase * altura;

        public decimal CalcularPerimetro() => 2 * (ladoBase + altura);

        #endregion
    }
}
