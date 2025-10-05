namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 8

Nota de pràctiques: 10
Nota de l’examen: 5
La nota final és 6.5 o sigui un 7 
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nota de practiques: ");
        double practiques = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nota de l'exanen: ");
        double examen = Convert.ToDouble(Console.ReadLine());

        double notaFinal = (practiques + examen) / 2;

        Console.WriteLine($"La nota final és {notaFinal:F1} o sigui un {(int)Math.Round(notaFinal)}");
    }
}
