using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Builders
{
    public static class DiccionarioBuilder
    {
        public static Dictionary<string, string> dictFormaGeometrica(Const.Idiomas _idioma)
        {
            var dict = new Dictionary<string, string>();
            switch (_idioma)
            {
                case Const.Idiomas.en:
                    dict.Add("ListEmpty", "<h1>Empty list of shapes!</h1>");
                    #region Cabecera de Reporte
                    dict.Add("HeaderReportName", "<h1>Shapes report</h1>");
                    #endregion
                    #region Pie de Reporte
                    dict.Add("FooterTotal", "TOTAL:<br/>");
                    dict.Add("FooterTotalShapes", "{0} shapes ");
                    dict.Add("FooterTotalPerimeter", "Perimeter {0} ");
                    dict.Add("FooterTotalArea", "Area {0}");
                    #endregion
                    #region Cuerpo de Reporte
                    dict.Add("BodyResumeLine", "{0} {1} | Area {2} | Perimeter {3} <br/>");
                    #endregion
                    #region Nombre de las Formas Singular/Plural
                    //Cuadrado
                    dict.Add("ShapeSingularSquare", "Square");
                    dict.Add("ShapePluralSquare", "Squares");
                    //Triángulo
                    dict.Add("ShapeSingularTriangle", "Triangle");
                    dict.Add("ShapePluralTriangle", "Triangles");
                    //Circulo
                    dict.Add("ShapeSingularCircle", "Circle");
                    dict.Add("ShapePluralCircle", "Circles");
                    //Rectángulo
                    dict.Add("ShapeSingularRectangle", "Rectangle");
                    dict.Add("ShapePluralRectangle", "Rectangles");
                    #endregion
                    break;
                case Const.Idiomas.es:
                    dict.Add("ListEmpty", "<h1>Lista vacía de formas!</h1>");
                    #region Cabecera de Reporte
                    dict.Add("HeaderReportName", "<h1>Reporte de Formas</h1>");
                    #endregion
                    #region Pie de Reporte
                    dict.Add("FooterTotal", "TOTAL:<br/>");
                    dict.Add("FooterTotalShapes", "{0} formas ");
                    dict.Add("FooterTotalPerimeter", "Perímetro {0} ");
                    dict.Add("FooterTotalArea", "Área {0}");
                    #endregion
                    #region Cuerpo de Reporte
                    dict.Add("BodyResumeLine", "{0} {1} | Área {2} | Perímetro {3} <br/>");
                    #endregion
                    #region Nombre de las Formas Singular/Plural
                    //Cuadrado
                    dict.Add("ShapeSingularSquare", "Cuadrado");
                    dict.Add("ShapePluralSquare", "Cuadrados");
                    //Triángulo
                    dict.Add("ShapeSingularTriangle", "Triángulo");
                    dict.Add("ShapePluralTriangle", "Triángulos");
                    //Circulo
                    dict.Add("ShapeSingularCircle", "Círculo");
                    dict.Add("ShapePluralCircle", "Círculos");
                    //Rectángulo
                    dict.Add("ShapeSingularRectangle", "Rectángulo");
                    dict.Add("ShapePluralRectangle", "Rectángulos");
                    #endregion
                    break;
                default:
                    break;
            }
            return dict;
        }
    }

    public static partial class Const
    {
        public enum Idiomas
        {
            en,
            es,
            it,
        }
    }
}
