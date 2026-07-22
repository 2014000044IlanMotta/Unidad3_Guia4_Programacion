internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1. Convertir decimal a binario");
        Console.WriteLine("2. Convertir binario a decimal");
        int opcion = Convert.ToInt32(Console.ReadLine());

        if (opcion == 1)
        {
            Console.Write("Ingrese un numero decimal: ");
            int decimalNum = Convert.ToInt32(Console.ReadLine());
            string binario = "";

            if (decimalNum == 0) binario = "0";

            while (decimalNum > 0)
            {
                int resto = decimalNum % 2;
                binario = resto.ToString() + binario;
                decimalNum = decimalNum / 2;
            }
            Console.WriteLine($"En binario es: {binario}");
        }
        else
        {
            Console.Write("Ingrese un numero binario: ");
            long binarioNum = Convert.ToInt64(Console.ReadLine());
            int decimalResultado = 0;
            int posicion = 0;

            while (binarioNum > 0)
            {
                int resto = (int)(binarioNum % 10);
                decimalResultado += resto * (int)Math.Pow(2, posicion);
                binarioNum /= 10;
                posicion++;
            }
            Console.WriteLine($"En decimal es: {decimalResultado}");
        }
    }
}
