internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad en metros: ");
        double metros = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Seleccione la unidad a la que desea convertir:");
        Console.WriteLine("a. Milimetros");
        Console.WriteLine("b. Centimetros");
        Console.WriteLine("c. Decimetros");
        Console.WriteLine("d. Hectometros");
        Console.WriteLine("e. Kilometros");
        string opcion = Console.ReadLine().ToLower();

        double resultado;
        switch (opcion)
        {
            case "a":
                resultado = metros * 1000;
                Console.WriteLine($"{metros} metros equivalen a {resultado} milimetros");
                break;
            case "b":
                resultado = metros * 100;
                Console.WriteLine($"{metros} metros equivalen a {resultado} centimetros");
                break;
            case "c":
                resultado = metros * 10;
                Console.WriteLine($"{metros} metros equivalen a {resultado} decimetros");
                break;
            case "d":
                resultado = metros / 100;
                Console.WriteLine($"{metros} metros equivalen a {resultado} hectometros");
                break;
            case "e":
                resultado = metros / 1000;
                Console.WriteLine($"{metros} metros equivalen a {resultado} kilometros");
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}
