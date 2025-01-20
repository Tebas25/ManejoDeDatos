using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeDatos.Models
{
    
    public class EstudianteUDLA
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(100)]
        public string Nombre { get; set; }


        [MaxLength(100)]
        public string Carrera { get; set;}
    }
}
