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

        private int ContarTaxis()
        {
            int contador = 0;

            foreach(TransportePublico taxi in transportes)
            {

                if(taxi is Taxi)
                {
                    contador++;
                }

            }

            return contador;
        }

        private int ContarOmnibus()
        {
            int contador = 0;

            foreach (TransportePublico omnibus in transportes)
            {

                if (omnibus is Omnibus)
                {
                    contador++;
                }

            }

            return contador;
        }


        public bool AgregarTransportePublico(string codigo, int pasajeros, char tipoTransportePublico, ListadoTransportePublico listado)
        {
            bool retorno = false;

            if(tipoTransportePublico == 't')
            {
                if(listado.ContarTaxis() < 5)
                {
                    Taxi taxi = new Taxi(pasajeros, codigo);
                    listado.transportes.Add(taxi);
                    retorno = true;
                }
                else { retorno = false;}

                
            }
            else
            {
                if (listado.ContarOmnibus() < 5)
                {
                    Omnibus ombnibus = new Omnibus(pasajeros, codigo);

                    listado.transportes.Add(ombnibus);
                    retorno = true;
                }
                else { retorno = false; }
            }
            return retorno;
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
