namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix el teu nom: ");
        string nom = Console.ReadLine();

        Console.Write("Introdueix el teu domini de correu: ");
        string domini = Console.ReadLine();

        string correu = nom + "@" + domini;

        Console.WriteLine($"La teva adreça de correu és: {correu}");
    }
}
