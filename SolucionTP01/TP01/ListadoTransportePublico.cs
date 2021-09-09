using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP01
{
    public class ListadoTransportePublico
    {
        
        public List<TransportePublico> transportes;

        public ListadoTransportePublico()
        {
            this.transportes = new List<TransportePublico>();
        }

        public bool AgregarTransportePublico(string codigo, int pasajeros, char tipoTransportePublico, ListadoTransportePublico listado)
        {
            if(tipoTransportePublico == 't')
            {
                Taxi taxi = new Taxi(pasajeros, codigo);
                listado.transportes.Add(taxi);
            }
            else
            {
                Omnibus ombnibus = new Omnibus(pasajeros, codigo);

                listado.transportes.Add(ombnibus);
            }
            return true;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            if(transportes.Count > 0)
            {
                foreach (TransportePublico vehiculo in this.transportes)
                {
                    cadena.AppendLine(vehiculo.ToString());
                }
            }
            else
            {
                cadena.AppendLine(" - No hay transportes publicos en el listado.");
            }

            return cadena.ToString();
        }

    }
}
