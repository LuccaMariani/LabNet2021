using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
    public static class MyExtensions
    {
        public static int DividirPor(this int dividendo, int divisor)
        {
            int cociente = dividendo / divisor;

            return cociente;
        }



        public static int MultiplicarPor(this int multiplicando, int multiplicador)
        {
            int producto = multiplicando * multiplicador;

            return producto;
        }
    }
}
