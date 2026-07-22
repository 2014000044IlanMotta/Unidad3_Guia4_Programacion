internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();

        char[] arreglo = frase.ToCharArray();
        Array.Reverse(arreglo);
        string invertida = new string(arreglo);

        Console.WriteLine($"Frase invertida: {invertida}");
    }
}
