using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoNT.Models
{
    public class Materia
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Materia(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
