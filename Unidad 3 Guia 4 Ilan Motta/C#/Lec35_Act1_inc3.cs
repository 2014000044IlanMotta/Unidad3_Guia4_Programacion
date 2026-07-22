internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Elige: piedra, papel o tijera: ");
        string opcionUsuario = Console.ReadLine().ToLower();

        Random random = new Random();
        int numeroAleatorio = random.Next(0, 3); 
        string opcionPC = "";

        switch (numeroAleatorio)
        {
            case 0: opcionPC = "piedra"; break;
            case 1: opcionPC = "papel"; break;
            case 2: opcionPC = "tijera"; break;
        }

        Console.WriteLine($"La computadora eligio: {opcionPC}");

        if (opcionUsuario == opcionPC)
        {
            Console.WriteLine("Empate");
        }
        else if ((opcionUsuario == "piedra" && opcionPC == "tijera") ||
                 (opcionUsuario == "papel" && opcionPC == "piedra") ||
                 (opcionUsuario == "tijera" && opcionPC == "papel"))
        {
            Console.WriteLine("Ganaste");
        }
        else
        {
            Console.WriteLine("Gano la computadora");
        }
    }
}
