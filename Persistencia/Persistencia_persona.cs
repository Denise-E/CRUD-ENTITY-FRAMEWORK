using POO_EntityFramework.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EntityFramework.Persistencia
{
    public class Persistencia_persona
    {
        PersonaContext context = new PersonaContext();
        public bool Crear(Persona p)
        {
            bool creado;
            try
            {
                context.Personas.Add(p);
                context.SaveChanges();
                creado = true;
            }
            catch {
                creado = false;
            }

            
            return creado;
        }

        public Persona? Leer(int id)
        {
            return context.Personas.Where(p => p.id == id).FirstOrDefault();
        }

        public List<Persona> LeerTodas()
        {
            return context.Personas.ToList(); // TODO APRTE DEL ENTITY FRAMEWORK
        }

        public bool Actualizar(Persona persona)
        {
            bool a = false;
            Persona? p = Leer(persona.id);

            if(p != null)
            {
                context.Personas.Update(persona); // Descubre por su cuenta la persona
                context.SaveChanges();
                a = true;
            }
            return a;
        }

        public bool Borrar(Persona p)
        {
            bool borrado;
            try
            {
                context.Personas.Remove(p);
                context.SaveChanges ();
                borrado = true;
            }
            catch
            {
                borrado = false;
            }

            return borrado;
        }
    }
}
