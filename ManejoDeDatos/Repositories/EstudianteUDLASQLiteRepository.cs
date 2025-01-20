using ManejoDeDatos.Interfaces;
using ManejoDeDatos.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeDatos.Repositories
{
    public class EstudianteUDLASQLiteRepository : IEstudianteUDLARepository
    {
        private static string NombreDB = "EstudianteUDLA.db3";
        private SQLiteConnection _conn;
        
        public EstudianteUDLASQLiteRepository() { Init(); }

        public void Init()
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, NombreDB);
            _conn = new SQLiteConnection(dbPath);
            _conn.CreateTable<EstudianteUDLA>();
        }

        public bool CreateEstudianteUDLA(EstudianteUDLA estudiante)
        {
            try
            {
                int insert = _conn.Insert(estudiante);
                if (insert > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteEstudianteUDLA(int id)
        {
            int eliminar  = _conn.Delete<EstudianteUDLA>(id);
            if (eliminar>0){
                return true;
            }
            else{
                return false;
            }
        }

        public EstudianteUDLA GetEstudianteUDLA(int id)
        {
            var estudiante = GetListEstudianteUDLA().ToList();
            if (estudiante.Any(item => item.ID == id))
            {
                return estudiante.Find(item => item.ID == id);
            }
            return _conn.Get<EstudianteUDLA>(id);
            return new EstudianteUDLA();
        }

        public IEnumerable<EstudianteUDLA> GetListEstudianteUDLA()
        {
           var listadoEstudiantes = _conn.Table<EstudianteUDLA>().ToList();
            return listadoEstudiantes;
        }

        public bool UpdateEstudianteUDLA(EstudianteUDLA estudiante)
        {
            try
            {
                int update = _conn.Update(estudiante);
                if (update > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
