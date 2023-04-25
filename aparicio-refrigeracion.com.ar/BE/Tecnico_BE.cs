using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tecnico_BE
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int CodPais { get; set; }
        public int CodLocalidad { get; set; }
        public int CodProvincia { get; set; }
        public string Domicilio { get; set; }

        public int Tel_DDI { get; set; }
        public int Tel_DDN { get; set; }
        public int Telefono { get; set; }
        public bool Celular { get; set; }

        public string CorreoElectrónico { get; set; }
        public string PáginaWeb { get; set; }


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
