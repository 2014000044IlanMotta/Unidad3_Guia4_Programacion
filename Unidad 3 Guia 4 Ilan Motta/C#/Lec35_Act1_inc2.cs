internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese el precio del producto: ");
        double precio = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la cantidad con la que pago el cliente: ");
        double pago = Convert.ToDouble(Console.ReadLine());

        double cambio = pago - precio;

        if (cambio < 0)
        {
            Console.WriteLine("El pago es insuficiente");
        }
        else
        {
            int restante = (int)Math.Round(cambio);

            int billete200 = restante / 200; restante %= 200;
            int billete100 = restante / 100; restante %= 100;
            int billete50 = restante / 50; restante %= 50;
            int billete20 = restante / 20; restante %= 20;
            int moneda10 = restante / 10; restante %= 10;
            int moneda5 = restante / 5; restante %= 5;
            int moneda1 = restante / 1;

            Console.WriteLine($"El cambio a entregar es: {cambio:F2}");
            Console.WriteLine($"Billetes de 200: {billete200}");
            Console.WriteLine($"Billetes de 100: {billete100}");
            Console.WriteLine($"Billetes de 50: {billete50}");
            Console.WriteLine($"Billetes de 20: {billete20}");
            Console.WriteLine($"Monedas de 10: {moneda10}");
            Console.WriteLine($"Monedas de 5: {moneda5}");
            Console.WriteLine($"Monedas de 1: {moneda1}");
        }
    }
}
