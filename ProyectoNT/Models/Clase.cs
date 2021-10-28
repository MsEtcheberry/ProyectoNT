using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoNT.Models
{
    public class Clase
    {
        //cambiar horario, tipo de dato
        public int id { get; set; }
        public string horario { get; set; }
        public DateTime fecha { get; set; }
        public string tema { get; set; }
        public Materia materia { get; set; }
        public Alumno alumno { get; set; }

        public Clase(int id, string horario, DateTime fecha, string tema, Materia materia, Alumno alumno)
        {
            this.id = id;
            this.horario = horario;
            this.fecha = fecha;
            this.tema = tema;
            this.materia = materia;
            this.alumno = alumno;
        }


    }
}
