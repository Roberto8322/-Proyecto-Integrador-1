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

        static void ImpCatalogo(List<Titulo> lista, string encabezado)
        {
            Console.WriteLine(encabezado);
            Console.WriteLine("ISBN               Titulo                                 Prestamos  Disponibles");
            
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

          
            OrdenInsercion(catalogo);

            ImpCatalogo(catalogo, "Catalogo Ordenado por Prestamos (Mayor a Menor)");
        }
    }
}