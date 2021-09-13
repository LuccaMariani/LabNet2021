using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TP02;

namespace ConsoleAppTP2
{
    public class InterfazConsola
    {
        public void IniciarInferfaz()
        {
            bool continuarPrograma = true;
            string opcion;

            MetodosPractica operacion = new MetodosPractica();

            Console.Title = "TP2 Excepciones y Extenciones - Mariani, Juan Luca";
            Console.WriteLine("=> Bievenido a los Metodos de division <=\n");

            while (continuarPrograma)
            {
                Console.WriteLine(" Opciones : \n\n 1 - Ingrese un numero que va a ser dividido por 0.\n 2 - Ingrese 2 numeros a ser divididos entre si.\n 3 - Disparar excepcion .\n 4 - Mismo ejercMismo ejercicio enterior, pero con excepcion propia.\n 5 - Salir\n");
                Console.WriteLine("- Ingrese el NUMERO de la opcion a realizar.");
                Console.Write(">");
                opcion = Console.ReadLine();

                Int32.TryParse(opcion, out int opcionParseada);

                Console.Clear();

                switch (opcionParseada)
                {
                    case 1:
                        int dividendoParseado;

                        Console.WriteLine("=> Metodo Uno <=\n");
                        Console.Write("- Ingrese el dividendo.");
                        string dividendo = Console.ReadLine();

                        while (!Int32.TryParse(dividendo, out dividendoParseado))
                        {
                            Console.WriteLine("- No es un numero valido, reintente\n>");

                            dividendo = Console.ReadLine();
                        }

                        try
                        {
                            Console.WriteLine("Resultado: " +  operacion.MetodoUno(dividendoParseado));
                        }
                        catch(DivideByZeroException)
                        {
                            Console.WriteLine(">> Excepcion: Solo Chuck Norris divide por cero!” ");
                        }
                        catch( Exception exc)
                        {
                            Console.WriteLine(">> Excepcion: " + exc.Message);
                        }


                        break;
                    case 2:
                        int divisorParseado;
                        int dividendoParseado2;

                        Console.WriteLine("=> Metodo Dos <=\n");
                        Console.Write("- Ingrese el dividendo.");
                        string dividendo2 = Console.ReadLine();

                        while (!Int32.TryParse(dividendo2,out dividendoParseado2))
                        {
                            Console.WriteLine("- No es un numero valido, reintente\n>");

                            dividendo2 = Console.ReadLine();
                        }

                        Console.Write("- Ingrese el divisor.");

                        string divisor = Console.ReadLine();

                        while (!Int32.TryParse(divisor, out divisorParseado))
                        {
                            Console.WriteLine("- No es un numero valido, reintente\n>");

                            divisor = Console.ReadLine();
                        }

                        try
                        {
                            Console.WriteLine("Resultado: " + operacion.MetodoDos(dividendoParseado2, divisorParseado));
                        }
                        catch (DivideByZeroException exc)
                        {
                            Console.WriteLine(">> Excepcion: " + exc.Message);
                        }
                        catch (Exception exc)
                        {
                            Console.WriteLine(">> Excepcion: " + exc.Message);
                        }


                        break;
                    case 3:
                        Console.WriteLine(" Punto 3 no realizado.");

                        break;
                    case 4:

                        int dividendoParseado3;

                        Console.WriteLine("=> Metodo Uno <=\n");
                        Console.Write("- Ingrese el dividendo.");
                        string dividendo3 = Console.ReadLine();

                        while (!Int32.TryParse(dividendo3, out dividendoParseado3))
                        {
                            Console.WriteLine("- No es un numero valido, reintente\n>");

                            dividendo3 = Console.ReadLine();
                        }

                        try
                        {
                            Console.WriteLine("Resultado: " + operacion.MetodoUno(dividendoParseado3));
                        }
                        catch (MyExceptions exc)
                        {
                            Console.WriteLine(exc.Message);
                        }


                        break;
                    case 5:
                        continuarPrograma = false;
                        break;
                    default:
                        Console.WriteLine("- Error al leer la opcion.");
                        break;
                }


                Console.WriteLine("\n > Presione una tecla para continuar. <");
                Console.ReadKey();
                Console.Clear();

            }


        }


    }
}
