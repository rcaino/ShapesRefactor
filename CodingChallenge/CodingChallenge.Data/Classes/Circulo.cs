﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : IFormaGeometrica
    {
        #region Propiedades
        private decimal radio { get; set; }

        public string Tipo => "Circle";

        #endregion

        #region Metodos
        public Circulo(decimal _diametro)
        {
            this.radio = _diametro / 2;
        }
        public decimal CalcularArea() => (decimal)Math.PI * radio * radio;

        public decimal CalcularPerimetro() => 2 * (decimal)Math.PI * radio;
        #endregion
    }
}
