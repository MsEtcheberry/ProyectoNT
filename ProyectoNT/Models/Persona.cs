using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNT.Models
{
    public class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }

        public Persona(int id, string nombre, string apellido, string mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
        }

        public void mostrarNombre()
        {
            Console.WriteLine(this.nombre);
        }
    }
}