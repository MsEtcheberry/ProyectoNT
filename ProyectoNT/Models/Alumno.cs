using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoNT.Models
{
    public class Alumno : Persona
    {
        public string escuela { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string grado { get; set; }


        public Alumno(int id, string nombre, string apellido, string mail, string escuela, DateTime fechaNacimiento, string grado) : base(id, nombre, apellido, mail)
        {
            this.escuela = escuela;
            this.fechaNacimiento = fechaNacimiento;
            this.grado = grado;
        }
    }
}
