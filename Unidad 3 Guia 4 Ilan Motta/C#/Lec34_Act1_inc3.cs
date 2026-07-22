internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese la temperatura en grados centigrados: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Convertir a:");
        Console.WriteLine("a. Fahrenheit");
        Console.WriteLine("b. Celsius");
        Console.WriteLine("c. Kelvin");
        string opcion = Console.ReadLine().ToLower();

        double resultado;
        switch (opcion)
        {
            case "a":
                resultado = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius} C equivalen a {resultado} F");
                break;
            case "b":
                resultado = celsius;
                Console.WriteLine($"{celsius} C equivalen a {resultado} C");
                break;
            case "c":
                resultado = celsius + 273.15;
                Console.WriteLine($"{celsius} C equivalen a {resultado} K");
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}
