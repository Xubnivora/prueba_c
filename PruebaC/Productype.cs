using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaC
{
    internal class Productype
    {
        public Productype(int v1, string v2)
        {
            Valor = v1;
            Nombre = v2;
        }


        public int Valor { get; }
        public string Nombre { get; }
    }
}
