using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public class Omnibus : TransportePublico
    {
        string codigo;
        public Omnibus(int pasajeros, string codigo) : base(pasajeros)
        {
            this.codigo = codigo;
        }
        

        public override string Avanzar()
        {
            return "El omnibus avanza.";
        }

        public override string Detenerse()
        {
            return "El omnibus se detiene.";
        }



        public override string ToString()
        {
            return "Omnibus " + this.codigo + ": " + this.pasajeros + " pasajeros.";
        }
    }
    
}
