using System;
using System.Collections.Generic;

namespace BibliotecaEscolar
{
    class Program
    {
        static void OrdenInsercion(List<Titulo> lista)
        {
            for (int i = 1; i < lista.Count; i++)
            {
                Titulo temp = lista[i];
                int j = i - 1;

                while (j >= 0 && lista[j].PrestamosHistoricos < temp.PrestamosHistoricos)
                {
                    lista[j + 1] = lista[j];
                    j--;
                }
                lista[j + 1] = temp;
            }
        }

        static int BusquedaBinaria(List<Titulo> lista, string isbn)
        {
            List<Titulo> listaOrdenada = new List<Titulo>(lista);
            listaOrdenada.Sort((a, b) => string.Compare(a.ISBN, b.ISBN, StringComparison.Ordinal));

            int inicio = 0;
            int fin = listaOrdenada.Count - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                int res = string.Compare(listaOrdenada[medio].ISBN, isbn, StringComparison.Ordinal);

                if (res == 0) return medio;
                if (res < 0) inicio = medio + 1;
                else fin = medio - 1;
            }

            return -1;
        }

        static void BusquedaSecuencial(List<Titulo> lista, string palabra)
        {
            bool encontrado = false;
            Console.WriteLine("Resultados para '" + palabra + "':");

            foreach (var item in lista)
            {
                if (item.Nombre.ToLower().Contains(palabra.ToLower()))
                {
                    Console.WriteLine("- " + item.ISBN + " " + item.Nombre + " (" + item.CopiasDisponibles + "/" + item.CopiasTotales + " libres)");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontraron coincidencias.");
            }
            Console.WriteLine();
        }

        static void ImpCatalogo(List<Titulo> lista, string encabezado)
        {
            Console.WriteLine(encabezado);
            Console.WriteLine("ISBN               Titulo                          Prestamos  Disponibles");

            foreach (var item in lista)
            {
                Console.WriteLine(item.ISBN + " " + item.Nombre.PadRight(37) + " " + item.PrestamosHistoricos.ToString().PadRight(9) + " " + item.CopiasDisponibles + "/" + item.CopiasTotales);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<Titulo> catalogo = new List<Titulo>
            {
                new Titulo("978-0131103627", "El Lenguaje de Programacion C", 45, 3),
                new Titulo("978-0201633610", "Patrones de Diseno", 30, 1),
                new Titulo("978-0132350884", "Codigo Limpio", 50, 5),
                new Titulo("978-0201896831", "El Arte de Programar Computadoras", 12, 2),
                new Titulo("978-0596007126", "Head First Design Patterns", 30, 4),
                new Titulo("978-0134685991", "Effective Java", 25, 1),
                new Titulo("978-0201485677", "Refactoring", 18, 3),
                new Titulo("978-0135957059", "The Pragmatic Programmer", 50, 2)
            };

            ImpCatalogo(catalogo, "Catalogo Inicial");

            catalogo[2].RegistrarPrestamo();
            catalogo[1].RegistrarPrestamo();

            OrdenInsercion(catalogo);

            ImpCatalogo(catalogo, "Catalogo Ordenado por Prestamos (Mayor a Menor)");

            Console.WriteLine("pruebas de busqueda");
            BusquedaSecuencial(catalogo, "Design");

            string isbnBuscar = "978-0132350884";
            int pos = BusquedaBinaria(catalogo, isbnBuscar);
            if (pos != -1)
            {
                Console.WriteLine("Busqueda Binaria: Encontrado el libro con ISBN " + isbnBuscar);
            }
            else
            {
                Console.WriteLine("Busqueda Binaria: ISBN no encontrado.");
            }
            Console.ReadKey();
        }
    }
}