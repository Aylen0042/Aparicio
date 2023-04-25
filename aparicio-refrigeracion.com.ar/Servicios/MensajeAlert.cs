namespace Servicios
{
    public class MensajeAlert
    {

        public string MensajeModal(string TituloVentana, string Mensaje)
        {
            string HtmlTexto;

            HtmlTexto = "";
            
            return HtmlTexto;
        }

    public string ScriptAlert(string Mensaje)
        {
            string Msj;

            Msj = @"<script type='text/javascript'>alert('" + Mensaje + "') </script>";
            return Msj;
        }

        public string scriptAlertModal(string Mensaje)
        {
            string Msj;

            Msj = @"<script type='text/javascript'>alert('" + Mensaje + "') </script>";
            return Msj;
        }

    }
}
