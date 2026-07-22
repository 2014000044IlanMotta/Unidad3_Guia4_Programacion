internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese su peso en kg: ");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese su altura en metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (altura * altura);
        Console.WriteLine($"Su IMC es: {imc:F2}");

        if (imc < 18.5)
            Console.WriteLine("Clasificacion: Bajo peso");
        else if (imc < 25)
            Console.WriteLine("Clasificacion: Peso normal");
        else if (imc < 30)
            Console.WriteLine("Clasificacion: Sobrepeso");
        else
            Console.WriteLine("Clasificacion: Obesidad");
    }
}
