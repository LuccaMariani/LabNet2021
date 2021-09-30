using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TP.EF.Logic;
using TP.EF.Entidades;

namespace TP.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
  
            Console.Title = "TP4 Entity Framework - Mariani, Juan Luca";
            Interface inter = new Interface();
            inter.StartInterface();

            Console.ReadKey();
        }
    }
}
