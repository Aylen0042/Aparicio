using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    internal class Helper_DAL
    {
        // Obtener String de Conexión (Archivo de Recursos en DAL)
        readonly string strConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;

        #region [--- METODOS PÚBLICOS ---]

        // -------------- EJECUTAR (SQL) --------------
        public int Ejecutar(string Consulta, SqlParameter[] Parametros)
        {
            int CantFilas;

            SqlConnection Conexion = new SqlConnection(strConexion);
            SqlCommand Comando = new SqlCommand(Consulta, Conexion)
            {
                CommandType = CommandType.Text
            };

            if (Parametros != null)
                Comando.Parameters.AddRange(Parametros);

            try
            {
                Conexion.Open();
                CantFilas = Comando.ExecuteNonQuery();
                Conexion.Close();
                Conexion.Dispose();
            }

            catch (SqlException ex)
            {
                Seguridad.Log Log = new Seguridad.Log();
                Log.Guardar(ex.Message, ex.StackTrace, "DAL", "Crítico");
                CantFilas = -1;
            }

            // Devolver Resultado
            return CantFilas;
        }



        // -------------- TRAER (SELECT) --------------
        public DataTable Traer(string Consulta, SqlParameter[] Parametros)
        {
            DataTable dt = new DataTable();

            SqlConnection Conexion = new SqlConnection(strConexion);
            SqlCommand Comando = new SqlCommand(Consulta, Conexion)
            {
                CommandType = CommandType.Text
            };
 
            if (Parametros != null)
                Comando.Parameters.AddRange(Parametros);

            try
            {
                Conexion.Open();
                SqlDataAdapter da = new SqlDataAdapter(Comando);
                da.Fill(dt);

                Comando.Dispose();
                da.Dispose();
                Conexion.Close();
                Conexion.Dispose();
            }

            catch (SqlException ex)
            {
                Seguridad.Log Log = new Seguridad.Log();
                Log.Guardar(ex.Message, ex.StackTrace, "DAL", "Crítico");
            }

            // Devolver Resultado
            return dt;
        }

        #endregion


        #region "[--- CREAR PARÁMETROS SQL ---]

        public SqlParameter CrearParametro(string Nombre, Guid Valor)
        {
            SqlParameter P = new SqlParameter
            {
                DbType = DbType.Guid,
                ParameterName = Nombre,
                Value = Valor
            };
            return P;
        }

        public SqlParameter CrearParametro(string Nombre, string Valor)
        {
            SqlParameter P = new SqlParameter
            {
                DbType = DbType.String,
                ParameterName = Nombre,
                Value = Valor
            };
            return P;
        }

        public SqlParameter CrearParametro(string Nombre, int Valor)
        {
            SqlParameter P = new SqlParameter
            {
                DbType = DbType.Int32,
                ParameterName = Nombre,
                Value = Valor
            };
            return P;
        }

        public SqlParameter CrearParametro(string Nombre, bool Valor)
        {
            SqlParameter P = new SqlParameter
            {
                DbType = DbType.Boolean,
                ParameterName = Nombre,
                Value = Valor
            };
            return P;
        }

        public SqlParameter CrearParametro(string Nombre, DateTime Valor)
        {
            SqlParameter P = new SqlParameter
            {
                DbType = DbType.DateTime,
                ParameterName = Nombre,
                Value = Valor
            };
            return P;
        }

        public SqlParameter CrearParametro(string Nombre, DateTimeOffset Valor)
        {
            SqlParameter P = new SqlParameter
            {
                DbType = DbType.DateTimeOffset,
                ParameterName = Nombre,
                Value = Valor
            };
            return P;
        }

        public SqlParameter CrearParametro(string Nombre, float Valor)
        {
            SqlParameter P = new SqlParameter
            {
                DbType = DbType.Single,
                ParameterName = Nombre,
                Value = Valor
            };
            return P;
        }

        public SqlParameter CrearParametro(string Nombre, decimal Valor)
        {
            SqlParameter P = new SqlParameter
            {
                DbType = DbType.Decimal,
                ParameterName = Nombre,
                Value = Valor
            };
            return P;
        }
        #endregion

        public string Convertir_ParametrosToString(SqlParameter[] Parametros)
        {
            string Registro = "";

            try
            {
                foreach (SqlParameter p in Parametros)
                    Registro += p.Value.ToString();
            }

            catch (Exception ex)
            {
                Seguridad.Log Log = new Seguridad.Log();
                Log.Guardar(ex.Message, ex.StackTrace, "Helper_DAL", "Crítico");
            }

            return Registro;
        }

        internal SqlParameter CrearParametro(string v, object codEstado)
        {
            throw new NotImplementedException();
        }
    }

}
