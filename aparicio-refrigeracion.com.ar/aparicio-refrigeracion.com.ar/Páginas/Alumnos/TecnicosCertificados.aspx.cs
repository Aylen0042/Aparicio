using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BE;
using BLL;

namespace aparicio_refrigeracion.com.ar.Páginas.Alumnos
{
    public partial class TecnicosCertificados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Llenar Combos
                LlenarListaDesplegable(ddlCodProvincia, "Provincias");
                LlenarListaDesplegable(ddlCodLocalidad, "Localidades");

                ddlCodProvincia.Items.Insert(0, "Todos");
                ddlCodLocalidad.Items.Insert(0, "Todos");

                LlenarListView();
            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Tecnico_BE Tecnico = new Tecnico_BE();

            if (ddlCodProvincia.SelectedIndex != 0)
                Tecnico.CodProvincia = ddlCodProvincia.SelectedIndex;

            if (ddlCodLocalidad.SelectedIndex != 0)
                Tecnico.CodLocalidad = ddlCodLocalidad.SelectedIndex;

            if (!string.IsNullOrEmpty(txtApellido.Text))
                Tecnico.Apellido = txtApellido.Text;

            if (!string.IsNullOrEmpty(txtNombre.Text))
                Tecnico.Nombre = txtNombre.Text;

            Tecnico_BLL TecnicoBLL = new Tecnico_BLL();
            
            lvTecnicosCertificados.DataSource = TecnicoBLL.TraerTodosPorFiltro(Tecnico);
            lvTecnicosCertificados.DataBind();
        }

        protected void btnQuitarFiltros_Click(object sender, EventArgs e)
        {
            ddlCodProvincia.SelectedIndex = 0;
            ddlCodLocalidad.SelectedIndex = 0;
            txtApellido.Text = "";
            txtNombre.Text = "";

            LlenarListView();
        }

        #region [FUNCIONES]

        private void LlenarListaDesplegable(DropDownList Lista, string Tabla)
        {
            Combo_BLL ComboBLL = new Combo_BLL();

            Lista.DataValueField = "Id";
            Lista.DataTextField = "Descripción";
            Lista.DataSource = ComboBLL.TraerTodos(Tabla);
            Lista.DataBind();
        }

        private void LlenarListView()
        {
            Tecnico_BLL TecnicoBLL = new Tecnico_BLL();
            System.Collections.Generic.List<Tecnico_BE> Tecnicos = TecnicoBLL.TraerTodos();

            lvTecnicosCertificados.DataSource = Tecnicos;
            lvTecnicosCertificados.DataBind();
        }

        #endregion

        protected void lvTecnicosCertificados_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                Combo_BLL ComboBLL = new Combo_BLL();
                Combo_BE Combo = new Combo_BE();

                Label lblProvincia = (Label)e.Item.FindControl("lblProvincia");
                int CodProvincia = System.Int32.Parse(DataBinder.Eval(e.Item.DataItem, "CodProvincia").ToString());

                Combo = ComboBLL.Traer(CodProvincia, "Provincias");
                lblProvincia.Text = Combo.Descripción;

                Label lblLocalidad= (Label)e.Item.FindControl("lblLocalidad");
                int CodLocalidad = System.Int32.Parse(DataBinder.Eval(e.Item.DataItem, "CodLocalidad").ToString());

                Combo = ComboBLL.Traer(CodLocalidad, "Localidades");
                lblLocalidad.Text = Combo.Descripción;


                HyperLink hlnkCorreoElectrónico = (HyperLink)e.Item.FindControl("hlnkCorreoElectrónico");
                string CorreoElectrónico = DataBinder.Eval(e.Item.DataItem, "CorreoElectrónico").ToString();
                hlnkCorreoElectrónico.NavigateUrl = "mailto:" + CorreoElectrónico;

                HyperLink hlnkPáginaWeb = (HyperLink)e.Item.FindControl("hlnkPáginaWeb");
                string PáginaWeb = DataBinder.Eval(e.Item.DataItem, "PáginaWeb").ToString();
                hlnkPáginaWeb.NavigateUrl = "http://" + PáginaWeb;
            }

        }
    }

}