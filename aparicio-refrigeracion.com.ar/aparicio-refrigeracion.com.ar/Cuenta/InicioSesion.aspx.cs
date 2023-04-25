using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aparicio_refrigeracion.com.ar.Cuenta
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        // GLOBAL
        //readonly MensajeAlert Msj = new MensajeAlert();

        protected void Page_Load(object sender, EventArgs e)
        {
            return;
        }

        protected void BtnIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        //protected void BtnIniciarSesion_Click(object sender, EventArgs e)
        //{
        //    // Validar que los campos Usuario y Contraseña no estén vacíos
        //    if (string.IsNullOrWhiteSpace(txtUsuario.Text))
        //    {
        //        MostrarMensaje("Inicio de Sesión", "El campo USUARIO está vacío");
        //        return;
        //    }

        //    if (string.IsNullOrWhiteSpace(txtContraseña.Text))
        //    {
        //        MostrarMensaje("Inicio de Sesión", "El campo CONTRASEÑA está vacío");
        //        return;
        //    }



        //    // Verificar si existe el Usuario
        //    var Usuario = new Usuario_BLL();

        //    if (!Usuario.Existe(txtUsuario.Text))
        //    {
        //        MostrarMensaje("Inicio de Sesión", "USUARIO O CONTRASEÑA INCORRECTOS");
        //        return;
        //    }

        //    // Cifrar Contraseña
        //    string ContraseñaCifrada = Seguridad.Cifrado.CalcularHash(txtContraseña.Text, Seguridad.Cifrado.AlgoritmoHash.SHA1);

        //    Usuario_BE UsuarioBE = Usuario.Traer(txtUsuario.Text, ContraseñaCifrada);

        //    if (UsuarioBE == null)
        //    {
        //        MostrarMensaje("Inicio de Sesión", "USUARIO O CONTRASEÑA INCORRECTOS");
        //        return;
        //    }

        //    // Guardar el objeto Usuario en la Sesión
        //    Session["Usuario"] = UsuarioBE;
        //    FormsAuthentication.RedirectFromLoginPage(UsuarioBE.Usuario, false);
        //}


        //#region [FUNCIONES]

        //public void MostrarMensaje(string Titulo, string Mensaje)
        //{
        //    lblTitulo.Text = Titulo;
        //    lblMensaje.Text = Mensaje;

        //    ScriptManager.RegisterStartupScript(this, this.GetType(), "ventanaPopUp", "abrirModal()", true);
        //}

        //#endregion

    }
}