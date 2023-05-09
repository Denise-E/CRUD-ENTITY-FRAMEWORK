using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EntityFramework.Entidades
{
    public  class Persona
    {
        public int id { get; set; }
        public string? nombre { get; set; } // Admito nulos.
    }
}
