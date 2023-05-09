using Microsoft.EntityFrameworkCore; // Para :DB
using POO_EntityFramework.Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EntityFramework.Persistencia
{
    public class PersonaContext:DbContext
    {
        //Crear tabla
        public DbSet<Persona> Personas { get; set; } // + importar Entidades. Defino tablas

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-BKKMKDA\\MSSQLSERVER01; Initial Catalog = PersonasDB; Integrated Security = true; Encrypt = true; TrustServerCertificate = true;");
            /*
             * Defino BBDD, Sercidor y Seguridad. Seteos para la conexion.
                Al configurarse la acc contra la BBDD uso optionsBuilder para setear el string de colleccion,
                el texto que tenemos que escribir para conectarnos. Varia seg[un BBDD. 
                Nombre servidor donde esta la BBDD, noMbre BBDD y tipo de seguridad (COMO ACCEDO - integrada por defecto, sino hay que pasarle usuarios y clave.);
             */
        }
    }
}
