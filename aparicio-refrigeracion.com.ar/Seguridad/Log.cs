using System;
using System.IO;
using System.Web;

namespace Seguridad
{
    public class Log
    {
        public void Guardar(string Descripcion, string Trace, string Module, string NivelCriticidad)
        {
            // RutaLog definida en Rel Archivo de Recursos de DLL Seguridad
            
            //string Ruta = Properties.Resources.RutaLog;
            //string Ruta = @"D:\Desarrollo\VS2019\source\repos\aparicio-refrigeracion.com.ar";

            string Ruta = HttpContext.Current.Server.MapPath("/");

            DateTime Fecha = DateTime.Now;
            string Dia = Fecha.Day.ToString();
            string Mes = Fecha.Month.ToString();
            string Año = Fecha.Year.ToString();

            string NombreArchivo = "Log" + Año + Mes + Dia + ".log";
            Ruta += "\\" + NombreArchivo;

            try
            {
                using (StreamWriter writer = new StreamWriter(Ruta, true))
                {
                    writer.WriteLine("------------------------------------------------------------------------------");
                    writer.WriteLine("Fecha: " + Dia + "/" + Mes + "/" + Año);
                    writer.WriteLine("Hora: " + DateTime.Now.ToString("HH:mm:ss"));
                    writer.WriteLine("Nivel: " + NivelCriticidad);
                    writer.WriteLine("Modulo: " + Module);
                    writer.WriteLine("Descripcion: " + Descripcion);
                    writer.WriteLine("Trace:" + Trace);
                    writer.WriteLine();
                    writer.Close();
                }
            }
            catch
            {

            }
        }
    }

}
