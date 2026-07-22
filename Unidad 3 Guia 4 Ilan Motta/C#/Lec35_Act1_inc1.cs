internal class Program
{
    private static void Main(string[] args)
    {
        string continuar = "s";

        while (continuar.ToLower() == "s")
        {
            Console.Write("Ingrese la cantidad en Quetzales (GTQ): ");
            double cantidad = Convert.ToDouble(Console.ReadLine());

            double usd = cantidad / 7.75;
            double eur = cantidad / 8.40;
            double mxn = cantidad * 2.35;
            double hnl = cantidad * 3.20;
            double crc = cantidad * 70.50;

            Console.WriteLine($"Equivalente en Quetzales (GTQ): {cantidad:F2}");
            Console.WriteLine($"Equivalente en Dolares (USD): {usd:F2}");
            Console.WriteLine($"Equivalente en Euros (EUR): {eur:F2}");
            Console.WriteLine($"Equivalente en Pesos mexicanos (MXN): {mxn:F2}");
            Console.WriteLine($"Equivalente en Lempiras (HNL): {hnl:F2}");
            Console.WriteLine($"Equivalente en Colones costarricenses (CRC): {crc:F2}");

            Console.Write("Desea convertir otra cantidad? (s/n): ");
            continuar = Console.ReadLine();
        }
    }
}
