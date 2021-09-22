using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP04.EF.Entidades;

namespace TP04.EF.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T generic);
        void Delete(int id);
        void Update(int id, int option, string field);

    }
}
