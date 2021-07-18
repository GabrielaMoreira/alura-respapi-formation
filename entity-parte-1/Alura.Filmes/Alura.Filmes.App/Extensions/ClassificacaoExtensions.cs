using Alura.Filmes.App.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Extensions
{
    public static class ClassificacaoExtensions
    {
        public static string ParaString(this ClassificacaoIndicativo valor)
        {
            var mapa = new Dictionary<string, ClassificacaoIndicativo>
            {
                {"G", ClassificacaoIndicativo.Livre },
                {"PG", ClassificacaoIndicativo.MaioresQue10 },
                {"PG-13", ClassificacaoIndicativo.MaioresQue13 },
                {"R", ClassificacaoIndicativo.MaioresQue14 },
                {"NC-17", ClassificacaoIndicativo.MaioresQue18 }
            };

            return mapa.First(c => c.Value == valor).Key;
        }

        public static ClassificacaoIndicativo ParaValor(this string texto)
        {
            var mapa = new Dictionary<string, ClassificacaoIndicativo>
            {
                {"G", ClassificacaoIndicativo.Livre },
                {"PG", ClassificacaoIndicativo.MaioresQue10 },
                {"PG-13", ClassificacaoIndicativo.MaioresQue13 },
                {"R", ClassificacaoIndicativo.MaioresQue14 },
                {"NC-17", ClassificacaoIndicativo.MaioresQue18 }
            };
            return mapa.First(c => c.Key == texto).Value;
        }
    }
}
