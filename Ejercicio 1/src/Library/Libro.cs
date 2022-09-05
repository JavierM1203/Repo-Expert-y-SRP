using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        // public string LibrarySector { get ; set; } // Por Expert, No es responsabilidad del libro saber en qué sector de la libreria se encuentra
        // public string LibraryShelve { get ; set; } // No es responsabilidad del libro saber en qué estanteria se encuentra

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        /*
        Por SRP no corresponde a la clase libro la función de colocar los libros en la estanteria
        
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        */

    }
}