﻿using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Propietario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }  
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

    }
}
