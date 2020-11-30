using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrapecioRectangulo : IFormaGeometrica
    {
        #region Propiedades
        public string Tipo => "Trapeze";
        private decimal baseMayor;
        private decimal baseMenor;
        private decimal altura;
        #endregion

        #region Metodos
        public TrapecioRectangulo(decimal _baseMayor, decimal _baseMenor, decimal _altura)
        {
            baseMayor = _baseMayor;
            baseMenor = _baseMenor;
            altura = _altura;
        }

        public decimal CalcularArea() => (baseMayor + baseMenor) * altura / 2;

        public decimal CalcularPerimetro()
        {
            //Si las pérdidas por casteo entre double y decimal dan una diferencia mayor a la precisión requerida
            //implementar el cálculo aritmético https://www.youtube.com/watch?v=21z2JHB1hzs
            var difBase = (baseMayor - baseMenor);
            var ladoPendiente = (decimal)Math.Sqrt((double)(difBase * difBase + altura * altura));
            return baseMayor + baseMenor + altura + ladoPendiente;
        }
        #endregion
    }
}
