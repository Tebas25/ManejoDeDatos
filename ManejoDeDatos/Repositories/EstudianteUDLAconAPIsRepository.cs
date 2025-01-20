using ManejoDeDatos.Interfaces;
using ManejoDeDatos.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ManejoDeDatos.Repositories
{
    public class EstudianteUDLAconAPIsRepository : IEstudianteUDLARepository
    {
        public string _urlEndpoint = "https://freetestapi.com/api/v1/students";
        public bool CreateEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEstudianteUDLA(int id)
        {
            throw new NotImplementedException();
        }

        public EstudianteUDLA GetEstudianteUDLA(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EstudianteUDLA> GetListEstudianteUDLA()
        {
            throw new NotImplementedException();
            //using (HttpClient httpclient = new HttpClient())
            //{
            //    var response = await httpclient.GetAsync(_urlEndpoint);
            //    var json_data = response.Content.ReadAsStringAsync().Result;
            //    List<EstudianteAPI> estudianteAPI = JsonConvert.DeserializeObject<List<EstudianteAPI>>(json_data);
            //}
        }

        public bool UpdateEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }
    }
}
