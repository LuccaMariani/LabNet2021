using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
    public class MyExceptions : Exception 
    {
        public MyExceptions()
        {

        }

        public MyExceptions(string mensaje) : base(mensaje)
        {

        }

    }
}
