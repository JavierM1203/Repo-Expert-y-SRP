using System;
using System.Collections;

namespace SRP
{
    public class Libreria
    {
        // Creamos una nueva clase libreria que nos permita crear instancias (estanterias) con sus respectivos sectores y numero de estanteria
        public ArrayList Books = new ArrayList();
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        
        public Libreria(String librarySector, String libraryShelve)
        {
            this.LibrarySector = librarySector;
            this.LibraryShelve = libraryShelve;
        }

        public void ShelveBook(Book book)
        {
            this.Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            this.Books.Remove(book);
        }

    }
}