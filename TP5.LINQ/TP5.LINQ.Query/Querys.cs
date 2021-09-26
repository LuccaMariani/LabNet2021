using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TP5.LINQ.Query;
using TP5.LINQ.Data;

namespace TP5.LINQ.Query
{
    class Querys
    {

        public void Query1()
        {
            var query1 = GetAllShippers().Where(m => m.ShipperID < 2000);
        }

    }
}
