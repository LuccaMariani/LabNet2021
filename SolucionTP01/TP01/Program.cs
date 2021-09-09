using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuarPrograma = true;
            string opcion;

            ListadoTransportePublico listado = new ListadoTransportePublico();

            Console.Title = "Aplicacion de Transportes Publicos - Mariani, Juan Luca";
            Console.WriteLine("=> Bievenido a la aplicacion de Transportes Publicos<=\n");

            while (continuarPrograma)
            {
                Console.WriteLine(" Opciones : \n\n 1 - Agregar un TAXI.\n 2 - Agregar un OMBNIBUS.\n 3 - Listar TODOS los transportes publicos.\n 4 - Salir.\n");
                Console.WriteLine("- Ingrese el NUMERO de la opcion a realizar.");
                Console.Write(">");
                opcion = Console.ReadLine();

                Int32.TryParse(opcion, out int opcionParseada);

                Console.Clear();

                switch (opcionParseada)
                {
                    case 1:
                        Console.WriteLine("=> Agregar TAXI <=\n");

                        int pasajerosTaxiParseado;

                        Console.Write("- Ingrese el codigo de este taxi.\n>");
                        string codigoTaxi = Console.ReadLine();

                        Console.Write("- Ingrese la cantidad de pasajeros del taxi " + codigoTaxi + ".\n>");
                        string pasajerosTaxi = Console.ReadLine();

                        while (!Int32.TryParse(pasajerosTaxi, out pasajerosTaxiParseado))
                        {
                            Console.WriteLine("- No es un codigo numerico valido, reintente\n>");

                            pasajerosTaxi = Console.ReadLine();
                        }

                        listado.AgregarTransportePublico(codigoTaxi, pasajerosTaxiParseado, 't', listado);


                        break;
                    case 2:
                        Console.WriteLine("=> Agregar OMNIBUS <=\n");

                        int pasajerosOmnibusParseado;

                        Console.Write("- Ingrese el codigo de este omnibus.\n>");
                        string codigoOmnibus = Console.ReadLine();

                        Console.Write("- Ingrese la cantidad de pasajeros del omnibus " + codigoOmnibus + ".\n>");
                        string pasajerosOmnibus = Console.ReadLine();

                        while (!Int32.TryParse(pasajerosOmnibus, out pasajerosOmnibusParseado))
                        {
                            Console.WriteLine("- No es un codigo numerico valido, reintente\n>");

                            pasajerosOmnibus = Console.ReadLine();
                        }

                        listado.AgregarTransportePublico(codigoOmnibus, pasajerosOmnibusParseado, 'o', listado);

                        break;
                    case 3:
                        Console.WriteLine("=> Listado de Transportes Publicos <=\n\n");
                        Console.WriteLine(listado);

                        break;
                    case 4:
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
