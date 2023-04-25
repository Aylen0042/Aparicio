using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using BE;

namespace DAL
{
    public class Tecnico_DAL
    {
        // DEFINIR strConsulta COMO GLOBAL A LA CLASE
        string ConsultaSQL;

        public bool Existe(int Id)
        {
            ConsultaSQL = "SELECT Id ";
            ConsultaSQL += "FROM T_Tecnicos ";
            ConsultaSQL += "WHERE (Id = @Id)";

            Helper_DAL Helper = new Helper_DAL();

            SqlParameter[] Parametros = new SqlParameter[1];
            Parametros[0] = Helper.CrearParametro("@Id", Id);

            DataTable dt = new DataTable();
            dt = Helper.Traer(ConsultaSQL, Parametros);

            bool Exito = (dt.Rows.Count >= 1);

            return Exito;
        }

        public bool Crear(Tecnico_BE Tecnico)
        {
            bool Exito = false;

            ConsultaSQL = "INSERT T_Tecnicos ";
            ConsultaSQL += "(Nombre, Apellido, CodPais, CodProvincia, CodLocalidad, Domicilio, Tel_DDI, Tel_DDN, Telefono, Celular, CorreoElectrónico, PaginaWeb) ";
            ConsultaSQL += "VALUES (@Nombre, @Apellido, @CodPais, @CodProvincia, @CodLocalidad, @Domicilio, @Tel_DDI, @Tel_DDN, @Telefono, @Celular, @CorreoElectrónico, @PaginaWeb)";

            Helper_DAL Helper = new Helper_DAL();

            SqlParameter[] Parametros = new SqlParameter[11];
            //Parametros[0] = Helper.CrearParametro("@Id", Tecnico.Id); // Es Identity
            Parametros[0] = Helper.CrearParametro("@Nombre", Tecnico.Nombre);
            Parametros[1] = Helper.CrearParametro("@Apellido", Tecnico.Apellido);
            Parametros[2] = Helper.CrearParametro("@CodPais", Tecnico.CodPais);
            Parametros[3] = Helper.CrearParametro("@CodProvincia", Tecnico.CodProvincia);
            Parametros[4] = Helper.CrearParametro("@CodLocalidad", Tecnico.CodLocalidad);
            Parametros[5] = Helper.CrearParametro("@Domicilio", Tecnico.Domicilio);
            Parametros[6] = Helper.CrearParametro("@Tel_DDI", Tecnico.Tel_DDI);
            Parametros[7] = Helper.CrearParametro("@Tel_DDN", Tecnico.Tel_DDN);
            Parametros[8] = Helper.CrearParametro("@Celular", Tecnico.Celular);
            Parametros[9] = Helper.CrearParametro("@CorreoElectrónico", Tecnico.CorreoElectrónico);
            Parametros[10] = Helper.CrearParametro("@PaginaWeb", Tecnico.PáginaWeb);

            int CantFilas = Helper.Ejecutar(ConsultaSQL, Parametros);

            if (CantFilas >= 1)
                Exito = true;

            return Exito;
        }

        public bool Actualizar(Tecnico_BE Tecnico)
        {
            bool Exito = false;

            //ConsultaSQL = "UPDATE T_Tecnicos ";
            //ConsultaSQL += "SET EstudioJuridico = @EstudioJuridico, FechaAlta = @FechaAlta, Contacto = @Contacto, ";
            //ConsultaSQL += "CorreoElectronico = @CorreoElectronico, Telefono = @Telefono, Interno = @Interno ";
            //ConsultaSQL += "WHERE Id = @Id";

            //Helper_DAL Helper = new Helper_DAL();

            //SqlParameter[] Parametros = new SqlParameter[8];
            //Parametros[0] = Helper.CrearParametro("@Id", Tecnico.Id); // Es Identity
            //Parametros[1] = Helper.CrearParametro("@FechaAlta", Tecnico.FechaAlta);
            //Parametros[2] = Helper.CrearParametro("@EstudioJuridico", Tecnico.EstudioJuridico);
            //Parametros[3] = Helper.CrearParametro("@Contacto", Tecnico.Contacto);
            //Parametros[4] = Helper.CrearParametro("@CorreoElectronico", Tecnico.CorreoElectronico);
            //Parametros[5] = Helper.CrearParametro("@Telefono", Tecnico.Telefono);
            //Parametros[6] = Helper.CrearParametro("@Interno", Tecnico.Interno);
            //Parametros[7] = Helper.CrearParametro("@Celular", Tecnico.Celular);

            //int CantFilas = Helper.Ejecutar(ConsultaSQL, Parametros);

            //if (CantFilas >= 1)
                Exito = true;

            return Exito;
        }

        public bool Eliminar(int Id)
        {
            bool Exito = false;

            ConsultaSQL = "DELETE T_Tecnicos ";
            ConsultaSQL += "WHERE Id = @Id";

            Helper_DAL Helper = new Helper_DAL();

            SqlParameter[] Parametros = new SqlParameter[1];
            Parametros[0] = Helper.CrearParametro("@Id", Id);

            int CantFilas = Helper.Ejecutar(ConsultaSQL, Parametros);

            if (CantFilas >= 1)
                Exito = true;

            return Exito;
        }

        public Tecnico_BE Traer(int Id)
        {
            ConsultaSQL = "SELECT * ";
            ConsultaSQL += "FROM T_Tecnicos ";
            ConsultaSQL += "WHERE (Id = @Id)";

            Helper_DAL Helper = new Helper_DAL();

            SqlParameter[] Parametros = new SqlParameter[1];
            Parametros[0] = Helper.CrearParametro("@Id", Id);

            DataTable dt = new DataTable();
            dt = Helper.Traer(ConsultaSQL, Parametros);

            if (dt.Rows.Count < 1)
                return null;

            DataRow drFila = dt.Rows[0];

            return DevolverObjeto(drFila);
        }

        public List<Tecnico_BE> TraerTodos()
        {
            ConsultaSQL = "SELECT * ";
            ConsultaSQL += "FROM T_Tecnicos";

            Helper_DAL Helper = new Helper_DAL();

            DataTable dt = Helper.Traer(ConsultaSQL, null);

            if (dt.Rows.Count < 1)
                return null;

            return DevolverLista(dt);

        }

        public List<Tecnico_BE> TraerTodosPorFiltro(Tecnico_BE Tecnico)
        {
            ConsultaSQL = "SELECT * ";
            ConsultaSQL += "FROM T_Tecnicos ";

            Helper_DAL Helper = new Helper_DAL();

            SqlParameter[] Parametros = new SqlParameter[4];

            Parametros[0] = Helper.CrearParametro("@Nombre", Tecnico.Nombre+"");
            Parametros[1] = Helper.CrearParametro("@Apellido", Tecnico.Apellido+"");
            Parametros[2] = Helper.CrearParametro("@CodProvincia", Tecnico.CodProvincia+"");
            Parametros[3] = Helper.CrearParametro("@CodLocalidad", Tecnico.CodLocalidad+"");

            int CantCampos = 0;

            if (!string.IsNullOrEmpty(Tecnico.Apellido))
            {
                ConsultaSQL += " WHERE Apellido LIKE '%' + @Apellido + '%'";
                CantCampos += 1;
            }

            if (!string.IsNullOrEmpty(Tecnico.Nombre))
            {
                if (CantCampos == 0)
                    ConsultaSQL += " WHERE Nombre LIKE '%' + @Nombre + '%'";
                else
                    ConsultaSQL += " AND Nombre LIKE '%' + @Nombre + '%'";

                CantCampos += 1;
            }

            if (Tecnico.CodProvincia != 0)
            {
                if (CantCampos == 0)
                    ConsultaSQL += " WHERE CodProvincia = @CodProvincia";
                else
                    ConsultaSQL += " AND CodProvincia = @CodProvincia";

                CantCampos += 1;
            }

            if (Tecnico.CodLocalidad != 0)
            {
                if (CantCampos == 0)
                    ConsultaSQL += " WHERE CodLocalidad = @CodLocalidad";
                else
                    ConsultaSQL += " AND CodLocalidad = @CodLocalidad";

                CantCampos += 1;
            }

            DataTable dt = Helper.Traer(ConsultaSQL, Parametros);

            if (dt.Rows.Count < 1)
                return null;

            return DevolverLista(dt);

        }

        // Devolver para Llenar DropDownList (Combo)
        public List<Combo_BE> TraerTodosDropDownList()
        {
            ConsultaSQL = "SELECT Id as ID, EstudioJuridico AS Descripción ";
            ConsultaSQL += "FROM T_Tecnicos";

            Helper_DAL Helper = new Helper_DAL();

            DataTable dt = Helper.Traer(ConsultaSQL, null);

            if (dt.Rows.Count < 1)
                return null;

            return DevolverListaDropDownList(dt);

        }


        #region " [--- MÉTODOS PRIVADOS ---]

        private Tecnico_BE DevolverObjeto(DataRow drFila)
        {
            if (drFila.IsNull(0))
                return null;

            Tecnico_BE Tecnico = new Tecnico_BE
            {
                Id = System.Int32.Parse(drFila["Id"].ToString()),
                Nombre = drFila["Nombre"].ToString(),
                Apellido = drFila["Apellido"].ToString(),

                CodPais = System.Int32.Parse(drFila["CodPais"].ToString()),
                CodProvincia = System.Int32.Parse(drFila["CodProvincia"].ToString()),
                CodLocalidad = System.Int32.Parse(drFila["CodLocalidad"].ToString()),
                Domicilio = drFila["Domicilio"].ToString(),

                Tel_DDI = System.Int32.Parse(drFila["Tel_DDI"].ToString()),
                Tel_DDN = System.Int32.Parse(drFila["Tel_DDN"].ToString()),
                Telefono = System.Int32.Parse(drFila["Telefono"].ToString()),
                Celular  = System.Boolean.Parse(drFila["Celular"].ToString()),

                CorreoElectrónico = drFila["CorreoElectrónico"].ToString(),
                PáginaWeb = drFila["PaginaWeb"].ToString(),
            };

            return Tecnico;
        }

        private List<Tecnico_BE> DevolverLista(DataTable dt)
        {
            List<Tecnico_BE> Tecnicos = new List<Tecnico_BE>();

            for (int fila = 0; fila < dt.Rows.Count; fila++)
            {
                DataRow drowFila = dt.Rows[fila];
                Tecnicos.Add(DevolverObjeto(drowFila));
            }

            return Tecnicos;
        }

        // Devolver para Llenar DropDownList (Combo)
        private Combo_BE DevolverObjetoDropDownList(DataRow drFila)
        {
            if (drFila.IsNull(0))
                return null;

            Combo_BE Combo = new Combo_BE
            {
                Id = int.Parse(drFila["Id"].ToString()),
                Descripción = drFila["Descripción"].ToString()
            };

            return Combo;
        }

        private List<Combo_BE> DevolverListaDropDownList(DataTable dt)
        {
            List<Combo_BE> Combos = new List<Combo_BE>();

            for (int fila = 0; fila < dt.Rows.Count; fila++)
            {
                DataRow drowFila = dt.Rows[fila];
                Combos.Add(DevolverObjetoDropDownList(drowFila));
            }

            return Combos;
        }

        #endregion

    }

}
