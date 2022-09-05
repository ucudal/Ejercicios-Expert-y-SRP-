using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        string id;
        DateTime date;
        string place;

        public AppointmentService(string id, DateTime date, string place){
            this.id=id;
            this.date=date;
            this.place=place;
        }
        public string CreateAppointment(string id, string place)
        {if(string.IsNullOrEmpty(id)||string.IsNullOrEmpty(place)){

                return "No se pudo agendar la consulta";
            }
            else
            {
                return "Añadido correctamente";
            }
    
        }

    }
}

/*Inicialmente podemos decir que este código no cumple con el principio SRP ya que esta clase no cuenta con una funcionalidad única,
sino que más bien podría recibir cambios por diferentes factores*/
