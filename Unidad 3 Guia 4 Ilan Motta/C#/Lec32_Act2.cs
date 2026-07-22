internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese el mes de nacimiento (1-12): ");
        int mes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el dia de nacimiento: ");
        int dia = Convert.ToInt32(Console.ReadLine());

        string signo;

        if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19)) signo = "Aries";
        else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20)) signo = "Tauro";
        else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20)) signo = "Geminis";
        else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22)) signo = "Cancer";
        else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22)) signo = "Leo";
        else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22)) signo = "Virgo";
        else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22)) signo = "Libra";
        else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21)) signo = "Escorpio";
        else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21)) signo = "Sagitario";
        else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19)) signo = "Capricornio";
        else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18)) signo = "Acuario";
        else signo = "Piscis";

        Console.WriteLine($"Tu signo zodiacal es: {signo}");

        switch (signo)
        {
            case "Aries": Console.WriteLine("Hoy tendras mucha energia, aprovechala en tus proyectos."); break;
            case "Tauro": Console.WriteLine("Es un buen dia para poner los pies sobre la tierra."); break;
            case "Geminis": Console.WriteLine("La comunicacion sera tu mejor herramienta hoy."); break;
            case "Cancer": Console.WriteLine("Cuida tus emociones y rodeate de tu familia."); break;
            case "Leo": Console.WriteLine("Brillaras en cualquier lugar donde estes hoy."); break;
            case "Virgo": Console.WriteLine("Pon atencion a los detalles, te traeran buenos resultados."); break;
            case "Libra": Console.WriteLine("Busca el equilibrio entre el trabajo y el descanso."); break;
            case "Escorpio": Console.WriteLine("Tu intuicion estara mas fuerte que nunca."); break;
            case "Sagitario": Console.WriteLine("Es un buen momento para planear un viaje."); break;
            case "Capricornio": Console.WriteLine("La disciplina te llevara a cumplir tus metas."); break;
            case "Acuario": Console.WriteLine("Tus ideas originales sorprenderan a todos."); break;
            case "Piscis": Console.WriteLine("Confia en tu creatividad para resolver un problema."); break;
        }
    }
}
