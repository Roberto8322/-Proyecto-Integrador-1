using System;
using System.Collections.Generic;
namespace BibliotecaEscolar
{
 ÿ ÿclass Program
 ÿ ÿ{
 ÿ ÿ ÿ ÿstatic void Main(string[] args)
 ÿ ÿ ÿ ÿ{
 ÿ ÿ ÿ ÿ ÿ ÿList<Titulo> catalogo = new List<Titulo>
 ÿ ÿ ÿ ÿ ÿ ÿ{
 ÿ ÿ ÿ ÿ ÿ ÿ ÿ ÿnew Titulo("978-0131103627", "El Lenguaje de Programacion C", 45, 3),
 ÿ ÿ ÿ ÿ ÿ ÿ ÿ ÿnew Titulo("978-0201633610", "Patrones de Diseno", 30, 1),
 ÿ ÿ ÿ ÿ ÿ ÿ ÿ ÿnew Titulo("978-0132350884", "Codigo Limpio", 50, 5),
 ÿ ÿ ÿ ÿ ÿ ÿ ÿ ÿnew Titulo("978-0201896831", "El Arte de Programar Computadoras", 12, 2),
 ÿ ÿ ÿ ÿ ÿ ÿ ÿ ÿnew Titulo("978-0596007126", "Head First Design Patterns", 30, 4),
 ÿ ÿ ÿ ÿ ÿ ÿ ÿ ÿnew Titulo("978-0134685991", "Effective Java", 25, 1),
 ÿ ÿ ÿ ÿ ÿ ÿ ÿ ÿnew Titulo("978-0201485677", "Refactoring", 18, 3),
 ÿ ÿ ÿ ÿ ÿ ÿ ÿ ÿnew Titulo("978-0135957059", "The Pragmatic Programmer", 50, 2)
 ÿ ÿ ÿ ÿ ÿ ÿ};

 ÿ ÿ ÿ ÿ ÿ ÿConsole.WriteLine(" CATALOGO BASE DE LA BIBLIOTECA ");
 ÿ ÿ ÿ ÿ ÿ ÿforeach (var t in catalogo)
 ÿ ÿ ÿ ÿ ÿ ÿ{
 ÿ ÿ ÿ ÿ ÿ ÿ ÿ ÿConsole.WriteLine(t.ISBN + " - " + t.Nombre + " | Copias: " + t.Ejemplares.Length);
 ÿ ÿ ÿ ÿ ÿ ÿ}
 ÿ ÿ ÿ ÿ}
 ÿ ÿ}
}
