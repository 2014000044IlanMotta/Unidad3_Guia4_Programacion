internal class Program
{
    private static void Main(string[] args)
    {
        string[] nombres = new string[11];
        string[] telefonos = new string[11];

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Ingrese el nombre de la persona {i}: ");
            nombres[i] = Console.ReadLine();
            Console.Write($"Ingrese el telefono de la persona {i}: ");
            telefonos[i] = Console.ReadLine();
        }

        Console.WriteLine("Datos guardados con exito.");
        Console.Write("Ingrese la posicion que desea consultar (1-10), o 0 para salir: ");
        int posicion = Convert.ToInt32(Console.ReadLine());

        while (posicion != 0)
        {
            if (posicion >= 1 && posicion <= 10)
            {
                Console.WriteLine($"Nombre: {nombres[posicion]}");
                Console.WriteLine($"Telefono: {telefonos[posicion]}");
            }
            else
            {
                Console.WriteLine("Posicion invalida");
            }
            Console.Write("Ingrese otra posicion (1-10), o 0 para salir: ");
            posicion = Convert.ToInt32(Console.ReadLine());
        }
    }
}
