using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        
        // ShelveBook no debería ir dentro de la class Book.
        // El libro no deberia conocer información acerca de su libreria. 
        // Para solucionarlo, deberemos crear una class que se llame Libreria o similar, así si respetaría el principio SRP.
        // Esto se debe a que, con una clase llamada Libreria, esta se encargaría de conocer la ubicación del libro dentro de la libreria,
        // y no asume el libro esa responsabilidad, además de conocer la información del mismo. 
        // Cumpliendo con el principio Expert, para que la clase Libreria conozca el libro del cual esta guardando su ubicación en la biblioteca,
        // se le pasa por parametro un objeto de la clase Book, es decir, un Libro en sí. 
        

    }
    
}
