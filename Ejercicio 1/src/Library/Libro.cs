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
        /*La class book del código original no cumplía con el principio SRP, ya que no solo contenía funciones y datos acerca del libro,
        sino que tambien tenía datos acerca del ShelveBook que está mas relacionado con la ubicación de este libro en la librería, por 
        lo tanto decidí separar esta en diferentes clases para que cada una tenga una función única y que si debe ser modificada sea modificada 
        por una sola razón.*/



    }


}
