namespace Servicios
{
    public class MensajeAlertBase
    {
        public string scriptAlert(string Mensaje)
        {
            string Msj;

            Msj = @"<script type='text/javascript'>alert('" + Mensaje + "') </script>";
            return Msj;
        }
    }
}