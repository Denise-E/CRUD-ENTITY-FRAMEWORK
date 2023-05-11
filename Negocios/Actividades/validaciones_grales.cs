using System;

public class validaciones_generales
{
	public validaciones_generales()
	{
		string validarString(string msg)
		{
            Console.WriteLine(msg);
            string nombre = Console.ReadLine();

            while (nombre.IsNullOrEmpty())
            {
                Console.WriteLine(msg);
                nombre = Console.ReadLine();
            }

            return nombre;
        }

        int validarInt(string msg)
        {
            Console.WriteLine(msg);
            int id;
            bool sel_checked = int.TryParse(Console.ReadLine(), out id);

            while (!sel_checked)
            {
                Console.WriteLine(msg);
                sel_checked = int.TryParse(Console.ReadLine(), out id);
            }

            return id;
        }
	}
}
