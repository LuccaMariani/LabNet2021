using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TP02;

namespace ConsoleAppTP2
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfazConsola UI = new InterfazConsola();

            UI.IniciarInferfaz();

            Console.ReadKey();
        }
    }
}
