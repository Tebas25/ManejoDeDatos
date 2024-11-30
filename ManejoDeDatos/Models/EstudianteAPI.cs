using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeDatos.Models
{
    public class EstudianteAPI
    {
        public class Address
        {
            public string Street { get; set; }
            public string City { get; set; }
            public string Zip { get; set; }
            public string Country { get; set; }
        }

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public Address Address { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public List<string> Courses { get; set; }
            public double GPA { get; set; }
            public string Image { get; set; }
        }

    }
}
