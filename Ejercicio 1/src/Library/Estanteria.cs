using System;
using System.Collections.Generic;

namespace SRP
{    
    public class Estanteria
    {
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public List<Book> Listadelibros = new List<Book>();
        
        public void MetodoAñadir(Book libro){
            Listadelibros.Add(libro);

        }
        
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
    }
}
//Crear nueva clase con una lista de estanterías