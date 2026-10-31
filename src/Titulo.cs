using System;
namespace BibliotecaEscolar
{
    public class Titulo
    {
        public string ISBN { get; set; }
        public string Nombre { get; set; }
        public int PrestamosHistoricos { get; set; }
        public string[] Ejemplares { get; set; }

        public Titulo(string isbn, string nombre, int prestamosHistoricos, int cantidadCopias)
        {
            ISBN = isbn;
            Nombre = nombre;
            PrestamosHistoricos = prestamosHistoricos;
            Ejemplares = new string[cantidadCopias];
            for (int i = 0; i < cantidadCopias; i++)
            {
                Ejemplares[i] = "Ejemplar #" + (i + 1);
            }
        }
    }
}
