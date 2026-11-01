using System;

namespace BibliotecaEscolar
{
    public class Titulo
    {
        public string ISBN { get; set; }
        public string Nombre { get; set; }
        public int PrestamosHistoricos { get; set; }
        public int CopiasDisponibles { get; set; }
        public int CopiasTotales { get; set; }

        public Titulo(string isbn, string nombre, int prestamosHistoricos, int cantidadCopias)
        {
            ISBN = isbn;
            Nombre = nombre;
            PrestamosHistoricos = prestamosHistoricos;
            CopiasTotales = cantidadCopias;
            CopiasDisponibles = cantidadCopias;
        }

        public bool RegistrarPrestamo()
        {
            if (CopiasDisponibles > 0)
            {
                CopiasDisponibles--;
                PrestamosHistoricos++;
                return true;
            }
            return false;
        }
    }
}
