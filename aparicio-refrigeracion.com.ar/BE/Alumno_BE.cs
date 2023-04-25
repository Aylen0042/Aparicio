using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Alumno_BE
    {
        public int ID { get; set; }

        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Pais { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Domicilio { get; set; }

        public int Tel_DDI { get; set; }
        public int Tel_DDN { get; set; }
        public int Telefono { get; set; }
        public bool Celular { get; set; }

        public string CorreoElectrónico { get; set; }
        public string PaginaWeb { get; set; }


        public string NombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }

        public string TelefonoCompleto
        {
            get { return "(+" + Tel_DDI + ") " + Tel_DDN + " " + Telefono; }
        }

    }

}
