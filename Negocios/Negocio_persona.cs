using POO_EntityFramework.Entidades;
using POO_EntityFramework.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EntityFramework.Negocios
{
    public class Negocio_persona
    {
        Persistencia_persona pers = new Persistencia_persona();

        public bool Crear(Persona p)
        {
            return pers.Crear(p);
        }

        public Persona? Leer(int id)
        {
            return pers.Leer(id);
        }

        public List<Persona> LeerTodas()
        {
            return pers.LeerTodas();
        }

        public bool Actualizar(Persona p)
        {
            return pers.Actualizar(p);
        }

        public bool Borrar(Persona p)
        {
            return pers.Borrar(p);
        }
    }
}
