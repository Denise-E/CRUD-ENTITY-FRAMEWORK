using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_EntityFramework.Persistencia;
using POO_EntityFramework.Negocios.Entidades;
using POO_EntityFramework.Negocios.Actividades;
using System.Runtime.ConstrainedExecution;

namespace POO_EntityFramework
{
    internal class Program
    {
        static Actividad_persona neg = new Actividad_persona();
        static void Main()
        {

            Console.Clear();
            Console.WriteLine("MANEJO DE PERSONAS");
            Console.WriteLine("-------");
            Console.WriteLine("1 - Alta persona");
            Console.WriteLine("2 - Listar personas");
            Console.WriteLine("3 - Buscar persona");
            Console.WriteLine("4 - Actualizar persona");
            Console.WriteLine("5 - Borrar persona");
            Console.WriteLine("-------");
            Console.Write("Ingrese una de las opciones: ");

            short sel_verificado;
            bool sel_checked = short.TryParse(Console.ReadLine(), out sel_verificado);

            while (!sel_checked)
            {
                Console.WriteLine("Ingrese una opcion valida: ");
                sel_checked = short.TryParse(Console.ReadLine(), out sel_verificado);
            }


            switch (sel_verificado)
            {
                case 1:
                    {
                        Crear();
                        break;
                    }
                case 2:
                    {
                        Listar();
                        break;
                    }
                case 3:
                    {
                        Buscar();
                        break;
                    }
                case 4:
                    {
                        Actualizar();
                        break;
                    }
                case 5:
                    {
                        Borrar();
                        break;
                    }
            }
        }
            static void Crear()
            {
                Persona newP = new Persona();
                Console.WriteLine("Ingrese su nombre ");
                newP.nombre = Console.ReadLine();

                bool estado = neg.Crear(newP);

                if (estado)
                {
                    Console.WriteLine("Persona agregada");
                }
                else
                {
                    Console.WriteLine("Persona no agregada");
                }

                Console.ReadKey();
                Main();
        }


            static void Listar()
            {
                List<Persona> personas = neg.LeerTodas();
                foreach (Persona per in personas)
                {
                    Console.WriteLine("ID: " + per.id);
                    Console.WriteLine("Nombre: " + per.nombre);
                    Console.WriteLine("***********************");
                }

                Console.ReadKey();
                Main();
            }

        static void Buscar()
        {
            Console.WriteLine("Ingrese el id de la persona a buscar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Persona? p = neg.Leer(id);

            if (p != null)
            {
                Console.WriteLine("Los datos de la persona buscada son:");
                Console.WriteLine("ID: " + p.id);
                Console.WriteLine("Nombre: " + p.nombre);
                Console.WriteLine("***********************");
            }
            else
            {
                Console.WriteLine("No se encontró a nadie con el ID solicitado");
            }

            Console.ReadKey();
            Main();
        }

        static void Actualizar()
        {
            Console.WriteLine("Ingrese el id de la persona a actualizar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Persona? p = neg.Leer(id);

            if (p != null)
            {
                Console.WriteLine("Ingrese el nuevo nombre de la persona: ");
                string nombre = Console.ReadLine();

                while(nombre == null){
                    Console.WriteLine("Ingrese el nuevo nombre de la persona: ");
                    nombre = Console.ReadLine();
                }

                p.nombre = nombre;
                bool actualizado = neg.Actualizar(p);
                if (actualizado)
                {
                    Console.WriteLine("Persona actualizada");
                }
                else
                {
                    Console.WriteLine("Persona no actualizada");
                }
            }
            else
            {
                Console.WriteLine("Persona no encontrada");
            }

            Console.ReadKey();
            Main();
        }
        static void Borrar()
        {
            Console.WriteLine("Ingrese el id de la persona a borrar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Persona? p = neg.Leer(id);

            if (p != null)
            {
                bool borrado = neg.Borrar(p);
                if (borrado)
                {
                    Console.WriteLine("Persona borrada");
                }
                else
                {
                    Console.WriteLine("Persona no borrada");
                }
            }
            else
            {
                Console.WriteLine("Persona no encontrada");
            }

            Console.ReadKey();
            Main();
        }

    }

}