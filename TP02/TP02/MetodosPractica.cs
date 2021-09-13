using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
    public class MetodosPractica
    {
        public int MetodoUno(int dividendo)
        {
            int retorno = 0;
            try
            {
                retorno = dividendo.DividirPor(0);
            }
            catch (DivideByZeroException exc)
            {
                throw exc;
            }
            catch (Exception exc)
            {
                throw exc;
            }


            return retorno;
        }

        public int MetodoDos(int dividendo, int divisor)
        {
            int retorno = 0;

            try
            {
                dividendo.DividirPor(divisor);
            }
            catch(DivideByZeroException exc)
            {
                throw exc;
            }
            catch (Exception exc)
            {
                throw exc;
            }


            return retorno;
        }


        public int MetodoCuatro(int dividendo, int divisor)
        {
            int retorno = 0;

            try
            {
                retorno = dividendo.DividirPor(divisor);
            }
            catch(DivideByZeroException)
            {
                throw new MyExceptions("Excepcion propia: no se puede dividir por cero !");
            }
            catch (Exception)
            { 
                throw new MyExceptions("Excepcion propia: hubo un error en la division!");
            }

            return retorno;
        }

    }

}
