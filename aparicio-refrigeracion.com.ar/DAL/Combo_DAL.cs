using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using BE;

namespace DAL
{
    public class Combo_DAL
    {
        // DEFINIR strConsulta COMO GLOBAL A LA CLASE
        string ConsultaSQL;

        public bool Existe(int Id, string Tabla)
        {
            ConsultaSQL = "SELECT Id ";
            ConsultaSQL += "FROM TAux_" + Tabla + " ";
            ConsultaSQL += "WHERE (Id = @Id)";

            Helper_DAL Helper = new Helper_DAL();

            SqlParameter[] Parametros = new SqlParameter[1];
            Parametros[0] = Helper.CrearParametro("@Id", Id);

            DataTable dt = new DataTable();
            dt = Helper.Traer(ConsultaSQL, Parametros);

            bool Exito = (dt.Rows.Count >= 1);

            return Exito;
        }

        public bool Crear(Combo_BE Juzgado, string Tabla)
        {
            bool Exito = false;

            ConsultaSQL = "INSERT TAux_" + Tabla + " ";
            ConsultaSQL += "(Descripción) ";
            ConsultaSQL += "VALUES (@Descripción)";

            Helper_DAL Helper = new Helper_DAL();

            SqlParameter[] Parametros = new SqlParameter[1];
            //Parametros[0] = Helper.CrearParametro("@Id", Juzgado.Id); // Es Identity
            Parametros[0] = Helper.CrearParametro("@Descripción", Juzgado.Descripción);

            int CantFilas = Helper.Ejecutar(ConsultaSQL, Parametros);

            if (CantFilas >= 1)
                Exito = true;

            return Exito;
        }

        public bool Actualizar(Combo_BE Juzgado, string Tabla)
        {
            bool Exito = false;

            ConsultaSQL = "UPDATE TAux_" + Tabla + " ";
            ConsultaSQL += "SET Descripción = @Descripción ";
            ConsultaSQL += "WHERE Id = @Id";

            Helper_DAL Helper = new Helper_DAL();

            SqlParameter[] Parametros = new SqlParameter[2];
            Parametros[0] = Helper.CrearParametro("@Id", Juzgado.Id); // Es Identity
            Parametros[1] = Helper.CrearParametro("@Descripción", Juzgado.Descripción);

            int CantFilas = Helper.Ejecutar(ConsultaSQL, Parametros);

            if (CantFilas >= 1)
                Exito = true;

            return Exito;
        }

        public bool Eliminar(int Id, string Tabla)
        {
            bool Exito = false;

            ConsultaSQL = "DELETE TAux_" + Tabla + " ";
            ConsultaSQL += "WHERE Id = @Id";

            Helper_DAL Helper = new Helper_DAL();

            SqlParameter[] Parametros = new SqlParameter[1];
            Parametros[0] = Helper.CrearParametro("@Id", Id);

            int CantFilas = Helper.Ejecutar(ConsultaSQL, Parametros);

            if (CantFilas >= 1)
                Exito = true;

            return Exito;
        }

        public Combo_BE Traer(int Id, string Tabla)
        {
            ConsultaSQL = "SELECT ID, Descripción ";
            ConsultaSQL += "FROM TAux_" + Tabla + " ";
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


        public List<BE.Combo_BE> TraerTodos(string Tabla)
        {
            ConsultaSQL = "SELECT ID, Descripción ";
            ConsultaSQL += "FROM TAux_" + Tabla;

            Helper_DAL Helper = new Helper_DAL();

            DataTable dt = Helper.Traer(ConsultaSQL, null);

            if (dt.Rows.Count < 1)
                return null;

            return DevolverLista(dt);
        }





        #region " [--- MÉTODOS PRIVADOS ---]

        private Combo_BE DevolverObjeto(DataRow drFila)
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


        private List<Combo_BE> DevolverLista(DataTable dt)
        {
            List<Combo_BE> Combos = new List<Combo_BE>();

            for (int fila = 0; fila < dt.Rows.Count; fila++)
            {
                DataRow drowFila = dt.Rows[fila];
                Combos.Add(DevolverObjeto(drowFila));
            }

            return Combos;
        }

        #endregion


    }

}
