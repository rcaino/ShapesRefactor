using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Collections;
using System.IO;

namespace CodingChallenge.Data.Classes.Builders
{
    public class ImpresionBuilder
    {

        #region Clases Privadas
        private class ParcialesPorForma
        {
            #region Propiedades
            public string tipo { get; }
            public int cantidad { get; }
            public decimal sumArea { get; }
            public decimal sumPerimetro { get; }
            #endregion
            public ParcialesPorForma(string _tipo, int _cantidad, decimal _sumArea, decimal _sumPerimetro)
            {
                tipo = _tipo;
                cantidad = _cantidad;
                sumArea = _sumArea;
                sumPerimetro = _sumPerimetro;
            }
        }
        #endregion

        #region Propiedades
        private Dictionary<string, string> diccionario { get; set; }
        private Dictionary<string, string> diccionarioDefault { get; set; }
        #endregion

        #region Metodos
        public ImpresionBuilder(Const.Idiomas _idioma)
        {
            diccionario = DiccionarioBuilder.dictFormaGeometrica(_idioma);
            diccionarioDefault = _idioma == Const.Idiomas.en ? diccionario : DiccionarioBuilder.dictFormaGeometrica(Const.Idiomas.en);
        }

        public string Imprimir(List<IFormaGeometrica> formas)
        {

            if (formas == null || formas.Count == 0)
            {
                return obtenerClave("ListEmpty");
            }

            var sb = new StringBuilder();
            sb.Append(armarCabecera());
            sb.Append(armarCuerpo(formas));
            sb.Append(armarPie(formas));
            return sb.ToString();
        }

        private string obtenerClave(string clave)
        {
            return diccionario.ContainsKey(clave) ? diccionario[clave] : diccionarioDefault[clave];
        }

        #region Cabecera
        private string armarCabecera()
        {
            return obtenerClave("HeaderReportName");
        }
        #endregion

        #region Cuerpo
        private string armarCuerpo(List<IFormaGeometrica> formas)
        {
            //Agrupo por tipo de forma
            var parciales = formas.GroupBy(forma => forma.Tipo).Select(grupo =>
               new ParcialesPorForma(
                   grupo.Key,
                   grupo.Count(),
                   grupo.Sum(forma => forma.CalcularArea()),
                   grupo.Sum(forma => forma.CalcularPerimetro())
                  )
           ).ToList();

            //Añado los parciales por tipo de forma
            var sb = new StringBuilder();
            parciales.ForEach(acumuladorPorForma => sb.Append(armarBloqueDeCuerpo(acumuladorPorForma)));

            return sb.ToString();
        }

        private string armarBloqueDeCuerpo(ParcialesPorForma acumuladorPorForma)
        {
            var descripcionTipo = obtenerClave(
                (acumuladorPorForma.cantidad == 1 ? "ShapeSingular" : "ShapePlural") + acumuladorPorForma.tipo
                );
            var area = acumuladorPorForma.sumArea.ToString("#.##");
            var perimetro = acumuladorPorForma.sumPerimetro.ToString("#.##");
            return string.Format(obtenerClave("BodyResumeLine"), acumuladorPorForma.cantidad, descripcionTipo, area, perimetro);
        }
        #endregion

        #region Pie
        private string armarPie(List<IFormaGeometrica> formas)
        {
            var sb = new StringBuilder();
            sb.Append(obtenerClave("FooterTotal"));

            sb.Append(string.Format(obtenerClave("FooterTotalShapes"), formas.Count));

            var perimetroTotal = formas.Sum(forma => forma.CalcularPerimetro()).ToString("#.##");
            sb.Append(string.Format(obtenerClave("FooterTotalPerimeter"), perimetroTotal));

            var areaTotal = formas.Sum(forma => forma.CalcularArea()).ToString("#.##");
            sb.Append(string.Format(obtenerClave("FooterTotalArea"), areaTotal));

            return sb.ToString();
        }
        #endregion

        #endregion
    }
}
