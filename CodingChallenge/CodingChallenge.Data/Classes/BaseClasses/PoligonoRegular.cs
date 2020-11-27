using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class PoligonoRegular : IFormaGeometrica
    {
        #region Propiedades
        protected int lados { get; }
        protected decimal longitud { get;}

        public virtual string Tipo => this.GetType().Name;
        #endregion

        #region Metodos
        public PoligonoRegular(int _lados, decimal _longitud)
        {
            lados = _lados;
            longitud = _longitud;
        }

        public abstract decimal CalcularArea();

        public decimal CalcularPerimetro() => lados * longitud;
        #endregion
    }
}
