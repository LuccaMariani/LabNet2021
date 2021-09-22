using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TP04.EF.Logic;
using TP04.EF.Entidades;

namespace TP04.EF.UI
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
