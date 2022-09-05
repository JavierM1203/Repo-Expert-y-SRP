using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            
            // book1.ShelveBook("A","7"); Por SRP, no corresponde al libro la funcion de colocarse en la estanteria
            // book2.ShelveBook("B","3"); 
            
            // Para ello, creamos una instancia de la clase libreria y utilizamos su funcion de añadir libros

            Libreria shelfA7 = new Libreria("A", "7");
            Libreria shelfB3 = new Libreria("B", "3");

            shelfA7.ShelveBook(book1);
            shelfB3.ShelveBook(book2);

        }
    }
}