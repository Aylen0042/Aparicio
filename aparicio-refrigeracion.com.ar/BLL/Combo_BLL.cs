using System.Collections.Generic;

using DAL;
using BE;

namespace BLL
{
    public class Combo_BLL
    {
        // Declaración GLOBAL
        private readonly Combo_DAL ComboDAL = new Combo_DAL();

        public bool Existe(int Id, string Tabla) => ComboDAL.Existe(Id, Tabla);

        public bool Crear(Combo_BE Combo, string Tabla)
        {
            return ComboDAL.Crear(Combo, Tabla);
        }

        public bool Actualizar(Combo_BE Combo, string Tabla)
        {
            return ComboDAL.Actualizar(Combo, Tabla);
        }

        public bool Eliminar(int Id, string Tabla) => ComboDAL.Eliminar(Id, Tabla);

        public Combo_BE Traer(int Id, string Tabla)
        {
            return ComboDAL.Traer(Id, Tabla);
        }


        public List<Combo_BE> TraerTodos(string Tabla)
        {
            return ComboDAL.TraerTodos(Tabla);
        }

    }

}
