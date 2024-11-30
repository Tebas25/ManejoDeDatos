using ManejoDeDatos.Interfaces;
using ManejoDeDatos.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ManejoDeDatos.Repositories
{
    public class EstudianteUDLAPorArchivosRepository : IEstudianteUDLARepository
    {
        public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "estudiantes.txt");
        public bool CreateEstudianteUDLA(EstudianteUDLA estudiante)
        {
            try{
                string json_data = JsonConvert.SerializeObject(estudiante);
                File.WriteAllText(_fileName, json_data);
                return true;
            } catch (Exception){
                throw;
            }
        }

        public bool DeleteEstudianteUDLA(int id)
        {
            throw new NotImplementedException();
        }

        public EstudianteUDLA GetEstudianteUDLA(int id)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA();
            if (File.Exists(_fileName)){
                string json_data = File.ReadAllText(_fileName);
                estudiante = JsonConvert.DeserializeObject<EstudianteUDLA>(json_data);
            }
            return estudiante;
        }

        public IEnumerable<EstudianteUDLA> GetListEstudianteUDLA()
        {
            throw new NotImplementedException();
        }

        public bool UpdateEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }
    }
}
