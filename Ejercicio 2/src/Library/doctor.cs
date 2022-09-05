using System;
using System.Text;

namespace Library{
    public class doctor{
        string doctorname;
        string speciality;  
        public doctor(string doctorname, string speciality){
            this.doctorname=doctorname;
            this.speciality=speciality;
        }
        public string Agregardoctor(string doctorname, string speciality){
            if(string.IsNullOrEmpty(doctorname)||string.IsNullOrEmpty(speciality)){

                return "No se pudo agregar al doctor al sistema";
            }
            else
            {
                return "Añadido correctamente";
            }
            
        }
        
    }
}