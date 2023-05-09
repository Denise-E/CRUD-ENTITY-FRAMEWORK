using POO_EntityFramework.Entidades;
using POO_EntityFramework.Negocios;
main();
void main()
{
    Negocio_persona neg = new Negocio_persona();

    // Agregar persona
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

    Console.Clear();

    // Borrar persona
    Console.WriteLine("Ingrese el id de la persona a borrar: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Persona? p = neg.Leer(id);

    if(p != null)
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
   



    // Listando a las personas   
    List<Persona> personas = neg.LeerTodas();

    foreach (Persona per in personas)
    {
        Console.WriteLine("ID: " + per.id);
        Console.WriteLine("Nombre: " + per.nombre);
        Console.WriteLine("***********************");
    }
}