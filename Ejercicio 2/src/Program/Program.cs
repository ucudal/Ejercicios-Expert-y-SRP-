using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a= new DateTime(1,2,3);
            paciente paciente1= new paciente("Jorge","0994231231","8950489-3",18);
            doctor doctor1= new doctor("Mascarpone","Odontologo");
            AppointmentService reserva= new AppointmentService("Reserva n1",a,"Chacarita");
            string uno=paciente1.Agregarpaciente("Jorge","0994231231","8950489-3",18);
            string dos=doctor1.Agregardoctor("Mascarpone","Odontologo");
            string tres=reserva.CreateAppointment("Reserva n1","Chacarita");
            comprobador check= new comprobador();
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine(tres);
            Console.WriteLine(check.comprobar(uno,dos,tres));


        }
    }
}
