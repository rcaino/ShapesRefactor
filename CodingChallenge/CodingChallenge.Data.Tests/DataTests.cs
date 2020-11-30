using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;
using CodingChallenge.Data.Classes.Builders;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        ImpresionBuilder Spanish { get; set; }
        ImpresionBuilder English { get; set; }
        ImpresionBuilder Italian { get; set; }

        [OneTimeSetUp]
        public void Init()
        {
            Spanish = new ImpresionBuilder(Const.Idiomas.es);
            English = new ImpresionBuilder(Const.Idiomas.en);
            Italian = new ImpresionBuilder(Const.Idiomas.it);
        }

        #region Lista Vacía
        [TestCase]
        public void TestResumenListaVaciaEsp()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", Spanish.Imprimir(new List<IFormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaVaciaEng()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", English.Imprimir(new List<IFormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaVaciaIta()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>", Italian.Imprimir(new List<IFormaGeometrica>()));
        }
        #endregion

        #region Una Forma de un Tipo
        [TestCase]
        public void TestResumenListaConUnCuadradoEsp()
        {
            var cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };

            var resumen = Spanish.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 formas Perímetro 20 Área 25", resumen);
        }

        [TestCase]
        public void TestResumenRectanguloIta()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Rectangulo(5,2),
            };

            var resumen = Italian.Imprimir(formas);

            Assert.AreEqual("<h1>Rapporto di forme</h1>1 Rettangolo | Area 10 | Perimetro 14 <br/>TOTALE:<br/>1 forme Perimetro 14 Area 10", resumen);
        }

        [TestCase]
        public void TestResumenTrapecioEng()
        {
            var formas = new List<IFormaGeometrica>
            {
                new TrapecioRectangulo(8,5,4),
            };

            var resumen = English.Imprimir(formas);

            Assert.AreEqual("<h1>Shapes report</h1>1 Trapeze | Area 26 | Perimeter 22 <br/>TOTAL:<br/>1 shapes Perimeter 22 Area 26", resumen);
        }

        #endregion

        #region Un Tipo más de una Forma
        [TestCase]
        public void TestResumenListaConMasCuadradosEng()
        {
            var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = English.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenTrapeciosEsp()
        {
            var formas = new List<IFormaGeometrica>
            {
                new TrapecioRectangulo(8,5,4), // a = 26, p = 22
                new TrapecioRectangulo(6,2,3), // a = 12, p = 16
                new TrapecioRectangulo(9.5m,6.5m,4)  // a = 32, p = 25
            };

            var resumen = Spanish.Imprimir(formas);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Trapecios | Área 70 | Perímetro 63 <br/>TOTAL:<br/>3 formas Perímetro 63 Área 70", resumen);
        }

        [TestCase]
        public void TestResumenRectangulosIta()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Rectangulo(5,2),
                new Rectangulo(2,2),
                new Rectangulo(1,7)
            };

            var resumen = Italian.Imprimir(formas);

            Assert.AreEqual("<h1>Rapporto di forme</h1>3 Rettangoli | Area 21 | Perimetro 38 <br/>TOTALE:<br/>3 forme Perimetro 38 Area 21", resumen);
        }
        #endregion

        #region n Tipos m Formas
        [TestCase]
        public void TestResumenListaConMasTiposEng()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = English.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEsp()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Spanish.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13,01 | Perímetro 18,06 <br/>3 Triángulos | Área 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 formas Perímetro 97,66 Área 91,65",
                resumen);
        }
        
        [TestCase]
        public void TestResumenListaConMasTiposIta()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Italian.Imprimir(formas);
            Assert.AreEqual(
                "<h1>Rapporto di forme</h1>2 Piazze | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>TOTALE:<br/>7 forme Perimetro 97,66 Area 91,65",
                resumen);
        }
        #endregion

    }
}
