using ManejoDeDatos.Models;
using Microsoft.UI.Xaml.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeDatos.Interfaces
{
    public interface IEstudianteUDLARepository
    {
        IEnumerable<EstudianteUDLA> GetListEstudianteUDLA();
        EstudianteUDLA GetEstudianteUDLA(int id);
        bool CreateEstudianteUDLA(EstudianteUDLA estudiante);
        bool UpdateEstudianteUDLA(EstudianteUDLA estudiante);
        bool DeleteEstudianteUDLA(int id);
    }
}
