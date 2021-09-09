using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public class Taxi : TransportePublico
    {
        string codigo;
        public Taxi(int pasajeros, string codigo) : base(pasajeros) 
        {
            this.codigo = codigo;
        }

        public override string Avanzar()
        {
            return "El taxi avanza.";
        }

        public override string Detenerse()
        {
            return "El taxi se detiene.";
        }

        public override string ToString()
        {
            return "Taxi " + this.codigo + ": " + this.pasajeros + " pasajeros.";
        }
    }
}
