using System.Collections.Generic;

using DAL;
using BE;

namespace BLL
{
    public class Tecnico_BLL
    {
        // Declaración GLOBAL
        readonly Tecnico_DAL TecnicoDAL = new Tecnico_DAL();

        public bool Existe(int Id) => TecnicoDAL.Existe(Id);

        public bool Crear(Tecnico_BE Tecnico) => TecnicoDAL.Crear(Tecnico);

        public bool Actualizar(Tecnico_BE Tecnico) => TecnicoDAL.Actualizar(Tecnico);

        public bool Eliminar(int Id) => TecnicoDAL.Eliminar(Id);

        public Tecnico_BE Traer(int Id) => TecnicoDAL.Traer(Id);

        public List<Tecnico_BE> TraerTodos() => TecnicoDAL.TraerTodos();

        public List<Tecnico_BE> TraerTodosPorFiltro(Tecnico_BE Tecnico)
        {

            return TecnicoDAL.TraerTodosPorFiltro(Tecnico);
        }

        public List<Combo_BE> TraerTodosDropDownList() => TecnicoDAL.TraerTodosDropDownList();

    }

}
