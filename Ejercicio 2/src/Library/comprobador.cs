using System;
using System.Text;

namespace Library{
    public class comprobador{
        public string comprobar(string paciente,string doctor,string reserva){
            if((paciente=="Añadido correctamente")&&(doctor=="Añadido correctamente")&&(reserva=="Añadido correctamente")){
                return "Se agendo la consulta correctamente";
            }else{
                return "No se ha podido realizar la reserva";
            }
        }
    }
}
/*El código principal en un comienzo no cumplía con el principio SRP ya que tenía muchas funciones de diferentes tipos de datos.
Por lo tanto decidí realizar nuevas clases, para que según el tipo de información y función se repartiera de forma que si se debe 
modificar la nueva clase, se modifique solo por una razón*/
/*La clase comprobador es la que imita el funcionamiento AppointementService del código anterior pero ya con las nuevas clases separadas*/