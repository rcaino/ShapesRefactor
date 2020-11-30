using CodingChallenge.Data.Classes.DictionariesResources;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
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
                    dict.LoadDictionary(ShapesReport_en.ResourceManager);
                    break;
                case Const.Idiomas.es:
                    dict.LoadDictionary(ShapesReport_es.ResourceManager);
                    break;
                case Const.Idiomas.it:
                    dict.LoadDictionary(ShapesReport_it.ResourceManager);
                    break;
                default:
                    break;
            }
            return dict;
        }

        public static void LoadDictionary(this Dictionary<string,string> dict, ResourceManager res )
        {
            {
                var resx = res.GetResourceSet(Thread.CurrentThread.CurrentCulture, true, true);
                foreach (DictionaryEntry registro in resx)
                {
                    dict.Add(registro.Key.ToString(), registro.Value.ToString());
                }
            }
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
