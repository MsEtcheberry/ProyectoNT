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
        public DateTime fechaYHora { get; set; }
        public string tema { get; set; }
        public Materia materia { get; set; }
        public Alumno alumno { get; set; }

        public Clase(int id,DateTime fechayHora, string tema, Materia materia, Alumno alumno)
        {
            this.id = id;
            this.fechaYHora = fechaYHora;
            this.tema = tema;
            this.materia = materia;
            this.alumno = alumno;
        }


    }
}
