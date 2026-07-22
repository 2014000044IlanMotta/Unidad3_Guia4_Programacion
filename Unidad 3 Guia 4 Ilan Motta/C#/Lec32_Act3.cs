internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese la medida del lado 1: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la medida del lado 2: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la medida del lado 3: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("El triangulo es EQUILATERO");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("El triangulo es ISOSCELES");
        }
        else
        {
            Console.WriteLine("El triangulo es ESCALENO");
        }
    }
}
