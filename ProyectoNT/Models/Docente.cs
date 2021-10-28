using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoNT.Models
{
    public class Docente : Persona
    {
        public string descripcion { get; set; }
        private List<Materia> materias;

        public Docente(int id, string nombre, string apellido, string mail, string descripcion) : base(id, nombre, apellido, mail)
        {
            this.descripcion = descripcion;
            materias = new List<Materia>();
        }
    }
}
