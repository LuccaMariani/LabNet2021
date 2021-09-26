using System;
using TP5.LINQ.Logic;


namespace TP5.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Querys queryy = new Querys();

            Console.WriteLine("1. Query para devolver objeto customer:");
            Console.WriteLine(queryy.Query1());

            Console.WriteLine();

            Console.WriteLine("2. Query para devolver todos los productos sin stock");
            Console.WriteLine(queryy.Query2());

            Console.WriteLine();

            Console.WriteLine("3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad");
            Console.WriteLine(queryy.Query3());

            Console.WriteLine();

            Console.WriteLine("4. Query para devolver todos los customers de la Región WA");
            Console.WriteLine(queryy.Query4());

            Console.WriteLine();

            Console.WriteLine("5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789");
            Console.WriteLine(queryy.Query5());

            Console.WriteLine();

            Console.WriteLine("6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.");
            Console.WriteLine(queryy.Query6());

            Console.WriteLine();

            Console.WriteLine("7. Query para devolver Join entre Customers y Orders donde los customers sean de la Región WA y la fecha de orden sea mayor a 1 / 1 / 1997.");
            Console.WriteLine(queryy.Query7());

            Console.WriteLine();

            Console.WriteLine("8. Query para devolver los primeros 3 Customers de la  Región WA");
            Console.WriteLine(queryy.Query8());

            Console.WriteLine();

            Console.WriteLine("9. Query para devolver lista de productos ordenados por nombre");
            Console.WriteLine(queryy.Query9());

            Console.WriteLine();

            Console.WriteLine("10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.");
            Console.WriteLine(queryy.Query10());

            Console.ReadKey();

        }
    }
}
