using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aparicio_refrigeracion.com.ar.Páginas.Admin
{
    public partial class CRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                LlenarDropDownListPaises();
                LlenarDropDownListProvincias();
                LlenaDropDownListLocalidades();
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //string Conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Datos\Aparicio\Aparicio-refrigeracion.com.ar\Aparicio-refrigeracion.com.ar\App_Data\AparicioRefrigeracion.mdf; Integrated Security = True";
            string Conexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            SqlConnection conexion;

            conexion = new SqlConnection(Conexion);

            string sentencia = "SELECT * FROM T_Tecnicos WHERE DNI = '" + txtDNI.Text + "'";

            SqlCommand comando = new SqlCommand(sentencia, conexion);

            conexion.Open();
            SqlDataReader dr;
            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                lblMensaje.Text = "El tecnico ya existe. Intente con otro.";
                dr.Close();
            }
            else
            {
                dr.Close();

                DateTime fecha = DateTime.Today;

                string Dia = fecha.Day.ToString();
                string Mes = fecha.Month.ToString();
                string Año = fecha.Year.ToString();

                string F_Alta = Mes + "/" + Dia + "/" + Año;
                //string F_Vto = fecha.AddYears(1).ToString();
                string F_Vto = F_Alta;

                //int CodPais = Convert.ToInt32(DropDownListCodPais.DataValueField);
                int CodPais = Convert.ToInt32(DropDownListCodPais.SelectedIndex);
                int CodProv = Convert.ToInt32(DropDownListCodProv.SelectedIndex);
                int CodLocal = Convert.ToInt32(DropDownListCodLocal.SelectedIndex);

                Boolean Celular = false;

                if (CheckBoxCelular.Checked)
                    Celular = true;

                DeshabilitarEtiquetas();

                if (Validar() == true)
                {
                    sentencia = "INSERT INTO T_Tecnicos " +
                            "(MatriculaNro, DNI, Nombre, Apellido, CodPais, CodProvincia, CodLocalidad, Domicilio, Tel_DDI, Tel_DDN, Telefono" +
                            ", Celular, CorreoElectrónico, PaginaWeb, FechaAlta, FechaVto) " +
                            "VALUES " +
                            "('" + txtMatricula.Text + "', '" + txtDNI.Text + "', '" + txtNombre.Text + "', '" + txtApellido.Text + "', " +
                            "'" + CodPais + "', '" + CodProv + "', '" + CodLocal + "', '" + txtDomicilio.Text + "', " +
                            "'" + txtTelDDI.Text + "', '" + txtTelDDN.Text + "', '" + txtTelefono.Text + "', '" + Celular + "', " +
                            "'" + txtCorreo.Text + "', '" + txtPaginaWeb.Text + "', '" + F_Alta + "', '" + F_Vto + "')";

                    comando = new SqlCommand(sentencia, conexion);

                    comando.ExecuteNonQuery();

                    lblMensaje.Text = "Tecnico creado correctamente.";
                    lblMensaje.Enabled = true;

                    LimpiarDatos();
                    LimpiarEtiquetas();
                }
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
          //  string Conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Datos\Aparicio\Aparicio-refrigeracion.com.ar\Aparicio-refrigeracion.com.ar\App_Data\AparicioRefrigeracion.mdf; Integrated Security = True";
            string Conexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            SqlConnection conexion;

            conexion = new SqlConnection(Conexion);

            int CodPais = Convert.ToInt32(DropDownListCodPais.SelectedIndex);
            int CodProv = Convert.ToInt32(DropDownListCodProv.SelectedIndex);
            int CodLocal = Convert.ToInt32(DropDownListCodLocal.SelectedIndex);


            string sentencia = "UPDATE T_Tecnicos SET CodPais = '" + CodPais + "', CodProvincia = '" + CodProv + "', " +
                "CodLocalidad = '" + CodLocal + "', Domicilio = '" + txtDomicilio.Text + "', Tel_DDI = '" + txtTelDDI.Text + "', " +
                "Tel_DDN = '" + txtTelDDN.Text + "', Telefono = '" + txtTelefono.Text + "', Celular = '" + CheckBoxCelular.Checked + "', " +
                "CorreoElectrónico = '" + txtCorreo.Text + "', PaginaWeb = '" + txtPaginaWeb.Text + "' WHERE DNI = '" + txtDNI.Text + "'";

            conexion.Open();

            SqlCommand comando = new SqlCommand(sentencia, conexion);

            int Valor;
            bool isNumber2 = int.TryParse(txtDNI.Text, out Valor);

            LimpiarEtiquetas();
            DeshabilitarEtiquetas();

            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                lblValidacionDNI.Text = "El campo necesita ser llenado.";
                lblValidacionDNI.Enabled = true;
            }
            else if (isNumber2 == false)
            {
                lblValidacionDNI.Text = "Error, no puede ingresar texto. Ingrese un numero para continuar.";
                lblValidacionDNI.Enabled = true;
            }
            else
            {
                comando.ExecuteNonQuery();

                lblMensaje.Text = "Tecnico actualizado correctamente.";
                lblMensaje.Enabled = true;

                conexion.Close();

                LimpiarDatos();
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            //string Conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Datos\Aparicio\Aparicio-refrigeracion.com.ar\Aparicio-refrigeracion.com.ar\App_Data\AparicioRefrigeracion.mdf; Integrated Security = True";
            string Conexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            SqlConnection conexion;

            conexion = new SqlConnection(Conexion);

            string sentencia = "DELETE FROM T_Tecnicos WHERE DNI = '" + txtDNI.Text + "'";

            conexion.Open();

            SqlCommand comando = new SqlCommand(sentencia, conexion);

            int Valor;
            bool isNumber2 = int.TryParse(txtDNI.Text, out Valor);

            LimpiarEtiquetas();
            DeshabilitarEtiquetas();

            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                lblValidacionDNI.Text = "El campo necesita ser llenado.";
                lblValidacionDNI.Enabled = true;
            }
            else if (isNumber2 == false)
            {
                lblValidacionDNI.Text = "Error, no puede ingresar texto. Ingrese un numero para continuar.";
                lblValidacionDNI.Enabled = true;
            }
            else
            {
                comando.ExecuteNonQuery();

                lblMensaje.Text = "Tecnico borrado correctamente.";
                lblMensaje.Enabled = true;

                conexion.Close();

                LimpiarDatos();
            }
        }

        protected void btnLeerDatos_Click(object sender, EventArgs e)
        {
            //string Conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Datos\Aparicio\Aparicio-refrigeracion.com.ar\Aparicio-refrigeracion.com.ar\App_Data\AparicioRefrigeracion.mdf; Integrated Security = True";
            string Conexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            SqlConnection conexion;

            conexion = new SqlConnection(Conexion);

            string sentencia = "SELECT * FROM T_Tecnicos WHERE DNI = '" + txtDNI.Text + "'";

            SqlCommand comando = new SqlCommand(sentencia, conexion);

            conexion.Open();
            SqlDataReader dr;
            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();

                txtMatricula.Text = dr["MatriculaNro"].ToString();
                txtDNI.Text = dr["DNI"].ToString();
                txtNombre.Text = dr["Nombre"].ToString();
                txtApellido.Text = dr["Apellido"].ToString();
                DropDownListCodPais.Text = dr["CodPais"].ToString();
                DropDownListCodProv.Text = dr["CodProvincia"].ToString();
                DropDownListCodLocal.Text = dr["CodLocalidad"].ToString();
                txtDomicilio.Text = dr["Domicilio"].ToString();
                txtTelDDI.Text = dr["Tel_DDI"].ToString();
                txtTelDDN.Text = dr["Tel_DDN"].ToString();
                txtTelefono.Text = dr["Telefono"].ToString();

                if (Convert.ToBoolean(dr["Celular"]) == true)
                    CheckBoxCelular.Checked = true;

                txtCorreo.Text = dr["CorreoElectrónico"].ToString();
                txtPaginaWeb.Text = dr["PaginaWeb"].ToString();
                txtFechaAlta.Text = dr["FechaAlta"].ToString();
                txtFechaVto.Text = dr["FechaVto"].ToString();

                dr.Close();
            }
            else
            {
                dr.Close();

                comando = new SqlCommand(sentencia, conexion);

                int Valor;
                bool isNumber2 = int.TryParse(txtDNI.Text, out Valor);

                LimpiarEtiquetas();
                DeshabilitarEtiquetas();

                if (string.IsNullOrEmpty(txtDNI.Text))
                {
                    lblValidacionDNI.Text = "El campo necesita ser llenado.";
                    lblValidacionDNI.Enabled = true;
                }
                else if (isNumber2 == false)
                {
                    lblValidacionDNI.Text = "Error, no puede ingresar texto. Ingrese un numero para continuar.";
                    lblValidacionDNI.Enabled = true;
                }
                else
                {
                    comando.ExecuteNonQuery();

                    lblMensaje.Text = "No existen datos porque el técnico no fue creado.";
                    lblMensaje.Enabled = true;
                }
            }
        }

        protected void LimpiarDatos()
        {
            txtMatricula.Text = "";
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            DropDownListCodPais.SelectedValue = "0";
            DropDownListCodProv.SelectedValue = "0";
            DropDownListCodLocal.SelectedValue = "0";
            txtDomicilio.Text = "";
            txtTelDDI.Text = "";
            txtTelDDN.Text = "";
            txtTelefono.Text = "";
            CheckBoxCelular.Checked = false;
            txtCorreo.Text = "";
            txtPaginaWeb.Text = "";
            txtFechaAlta.Text = "";
            txtFechaVto.Text = "";
        }

        protected void LimpiarEtiquetas()
        {
            lblValidacionMatricula.Text = "";
            lblValidacionDNI.Text = "";
            lblValidacionNombre.Text = "";
            lblValidacionApellido.Text = "";
            lblValidacionCodPais.Text = "";
            lblValidacionCodProv.Text = "";
            lblValidacionCodLocal.Text = "";
            lblValidacionDomicilio.Text = "";
            lblValidacionTelDDI.Text = "";
            lblValidacionTelDDN.Text = "";
            lblValidacionTelefono.Text = "";
        }

        protected bool Validar()
        {
            bool resultado = false;

            int Valor;
            bool isNumberMatricula = int.TryParse(txtMatricula.Text, out Valor);
            bool isNumberDNI = int.TryParse(txtDNI.Text, out Valor);
            bool isNumberTelDDI = int.TryParse(txtTelDDI.Text, out Valor);
            bool isNumberTelDDN = int.TryParse(txtTelDDN.Text, out Valor);
            bool isNumberTelefono = int.TryParse(txtTelefono.Text, out Valor);

            string Texto = "Error, no puede ingresar texto. Ingrese un numero para continuar.";
            string CampoLlenado = "El campo necesita ser llenado.";

            LimpiarEtiquetas();

            if(DropDownListCodPais.SelectedValue == "0")
            {
                lblValidacionCodPais.Text = CampoLlenado;
                lblValidacionCodPais.Enabled = true;
            }
            else if (DropDownListCodProv.SelectedValue == "0")
            {
                lblValidacionCodProv.Text = CampoLlenado;
                lblValidacionCodProv.Enabled = true;
            }
            else if (DropDownListCodLocal.SelectedValue == "0")
            {
                lblValidacionCodLocal.Text = CampoLlenado;
                lblValidacionCodLocal.Enabled = true;
            }
            else if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                lblValidacionMatricula.Text = CampoLlenado;
                lblValidacionMatricula.Enabled = true;
            }
            else if (string.IsNullOrEmpty(txtDNI.Text))
            {
                lblValidacionDNI.Text = CampoLlenado;
                lblValidacionDNI.Enabled = true;
            }
            else if (string.IsNullOrEmpty(txtNombre.Text))
            {
                lblValidacionNombre.Text = CampoLlenado;
                lblValidacionNombre.Enabled = true;
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                lblValidacionApellido.Text = CampoLlenado;
                lblValidacionApellido.Enabled = true;
            }
            else if (string.IsNullOrEmpty(DropDownListCodPais.Text))
            {
                lblValidacionCodPais.Text = CampoLlenado;
                lblValidacionCodPais.Enabled = true;
            }
            else if (string.IsNullOrEmpty(DropDownListCodProv.Text))
            {
                lblValidacionCodProv.Text = CampoLlenado;
                lblValidacionCodProv.Enabled = true;
            }
            else if (string.IsNullOrEmpty(DropDownListCodLocal.Text))
            {
                lblValidacionCodLocal.Text = CampoLlenado;
                lblValidacionCodLocal.Enabled = true;
            }
            else if (string.IsNullOrEmpty(txtDomicilio.Text))
            {
                lblValidacionDomicilio.Text = CampoLlenado;
                lblValidacionDomicilio.Enabled = true;
            }
            else if (string.IsNullOrEmpty(txtTelDDI.Text))
            {
                lblValidacionTelDDI.Text = CampoLlenado;
                lblValidacionTelDDI.Enabled = true;
            }
            else if (string.IsNullOrEmpty(txtTelDDN.Text))
            {
                lblValidacionTelDDN.Text = CampoLlenado;
                lblValidacionTelDDN.Enabled = true;
            }
            else
            {
                if (isNumberMatricula == false)
                {
                    lblValidacionMatricula.Text = Texto;
                    lblValidacionMatricula.Enabled = true;
                }
                else if (isNumberDNI == false)
                {
                    lblValidacionDNI.Text = Texto;
                    lblValidacionDNI.Enabled = true;
                }
                else if (isNumberTelDDI == false)
                {
                    lblValidacionTelDDI.Text = Texto;
                    lblValidacionTelDDI.Enabled = true;
                }
                else if (isNumberTelDDN == false)
                {
                    lblValidacionTelDDN.Text = Texto;
                    lblValidacionTelDDN.Enabled = true;
                }
                else if (isNumberTelefono == false)
                {
                    lblValidacionTelefono.Text = Texto;
                    lblValidacionTelefono.Enabled = true;
                }
                else
                    resultado = true;
            }
            return resultado;
        }

        protected void DeshabilitarEtiquetas()
        {
            lblValidacionMatricula.Enabled = false;
            lblValidacionDNI.Enabled = false;
            lblValidacionNombre.Enabled = false;
            lblValidacionDNI.Enabled = false;
            lblValidacionApellido.Enabled = false;
            lblValidacionCodPais.Enabled = false;
            lblValidacionCodProv.Enabled = false;
            lblValidacionCodLocal.Enabled = false;
            lblValidacionDomicilio.Enabled = false;
            lblValidacionTelDDI.Enabled = false;
            lblValidacionTelDDN.Enabled = false;
        }

        protected void LlenarDropDownListPaises()
        {
            //string Conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Datos\Aparicio\Aparicio-refrigeracion.com.ar\Aparicio-refrigeracion.com.ar\App_Data\AparicioRefrigeracion.mdf; Integrated Security = True";
            string Conexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            
            SqlConnection conexion = new SqlConnection(Conexion);

                    using (SqlCommand comando = new SqlCommand("SELECT * FROM TAux_Paises"))
                    {
                        ListItem ListCodPais = new ListItem();
                        ListCodPais.Value = "0";
                        ListCodPais.Text = "Seleccione...";

                        comando.CommandType = CommandType.Text;
                        comando.Connection = conexion;
                        conexion.Open();
                        DropDownListCodPais.DataSource = comando.ExecuteReader();
                        DropDownListCodPais.DataValueField = "Id";
                        DropDownListCodPais.DataTextField = "Descripción";
                        DropDownListCodPais.DataBind();
                        conexion.Close();

                        DropDownListCodPais.Items.Add(ListCodPais);
                        DropDownListCodPais.SelectedValue = "0";
            }
        }

        protected void LlenarDropDownListProvincias()
        {
            //string Conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Datos\Aparicio\Aparicio-refrigeracion.com.ar\Aparicio-refrigeracion.com.ar\App_Data\AparicioRefrigeracion.mdf; Integrated Security = True";
            string Conexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(Conexion);
            
                    using (SqlCommand comando = new SqlCommand("SELECT * FROM TAux_Provincias"))
                    {
                        ListItem ListCodProv = new ListItem();
                        ListCodProv.Value = "0";
                        ListCodProv.Text = "Seleccione...";

                        comando.CommandType = CommandType.Text;
                        comando.Connection = conexion;
                        conexion.Open();
                        DropDownListCodProv.DataSource = comando.ExecuteReader();
                        DropDownListCodProv.DataValueField = "Id";
                        DropDownListCodProv.DataTextField = "Descripción";
                        DropDownListCodProv.DataBind();
                        conexion.Close();
                        
                        DropDownListCodProv.Items.Add(ListCodProv);
                        DropDownListCodProv.SelectedValue = "0";
            }
        }

        protected void LlenaDropDownListLocalidades()
        {
            //string Conexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Datos\Aparicio\Aparicio-refrigeracion.com.ar\Aparicio-refrigeracion.com.ar\App_Data\AparicioRefrigeracion.mdf; Integrated Security = True";
            string Conexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;

            SqlConnection conexion = new SqlConnection(Conexion);

                    using (SqlCommand comando = new SqlCommand("SELECT * FROM TAux_Localidades"))
                    {
                        ListItem ListCodLocal = new ListItem();
                        ListCodLocal.Value = "0";
                        ListCodLocal.Text = "Seleccione...";

                        comando.CommandType = CommandType.Text;
                        comando.Connection = conexion;
                        conexion.Open();
                        DropDownListCodLocal.DataSource = comando.ExecuteReader();
                        DropDownListCodLocal.DataValueField = "Id";
                        DropDownListCodLocal.DataTextField = "Descripción";
                        DropDownListCodLocal.DataBind();
                        conexion.Close();

                        DropDownListCodLocal.Items.Add(ListCodLocal);
                        DropDownListCodLocal.SelectedValue = "0";
            }
        }

    }
}