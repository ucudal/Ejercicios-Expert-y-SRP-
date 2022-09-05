using System;
using System.Text;
namespace Library{
    public class paciente
    {
        string name;
        string phonenumber;
        string id;
        int age;
        public paciente(string name,string phonenumber,string id,int age){
            this.name=name;
            this.phonenumber=phonenumber;
            this.id=id;
            this.age=age;

        }
        public string Agregarpaciente(string name,string phonenumber,string id,int age){
            if(string.IsNullOrEmpty(name)||string.IsNullOrEmpty(phonenumber)||string.IsNullOrEmpty(id)||(age<0)){

                return "No se pudo agregar al paciente";
            }
            else
            {
                return "Añadido correctamente";
            }
            
        }
        
    }
}