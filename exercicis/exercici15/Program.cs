using System;
using System.Globalization;

namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix el teu nom: ");
        string nom = Console.ReadLine();

        Console.Write("Introdueix el teu Cognom: ");
        string cognom = Console.ReadLine();

        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        string nomComplet = ti.ToTitleCase(nom + " " + cognom);

        Console.WriteLine($"Nom complet: {nomComplet}");
    }
}
