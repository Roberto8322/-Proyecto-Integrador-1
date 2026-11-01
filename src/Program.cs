using System;
using System.Collections.Generic;

namespace BibliotecaEscolar
{
    class Program
    {
        static void MostrarCatalogo(List<Titulo> catalogo, string tituloSeccion)
        {
            Console.WriteLine(tituloSeccion);
            Console.WriteLine("ISBN                 Titulo                        Historico   Disponibles");
            foreach (var t in catalogo)
            {
                Console.WriteLine(t.ISBN + " " + t.Nombre.PadRight(37) + " " + t.PrestamosHistoricos.ToString().PadRight(9) + " " + t.CopiasDisponibles + "/" + t.CopiasTotales);
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

            MostrarCatalogo(catalogo, "catalog antes de los prestamos (DIA 3)");

            Console.WriteLine(" registrando 3 prestamos simulad");
            catalogo[2].RegistrarPrestamo(); 
            catalogo[1].RegistrarPrestamo();
            catalogo[2].RegistrarPrestamo(); 
            Console.WriteLine("1. Prestamo de 'Codigo Limpio' registrado.");
            Console.WriteLine("2. Prestamo de 'Patrones de Diseno' registrado.");
            Console.WriteLine("3. Segundo prestamo de 'Codigo Limpio' registrado.\n");

            MostrarCatalogo(catalogo, "catalogo despues de los prestamos ");
        }
    }
}