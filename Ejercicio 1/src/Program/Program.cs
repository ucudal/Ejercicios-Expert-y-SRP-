using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Estanteria estanteria1= new Estanteria();
            estanteria1.ShelveBook("A","1");
            estanteria1.MetodoAñadir(book1);
            Ubicacion ubicacion=new Ubicacion();
            ubicacion.MetodoEstanteria(estanteria1);



            
        }
    }
}