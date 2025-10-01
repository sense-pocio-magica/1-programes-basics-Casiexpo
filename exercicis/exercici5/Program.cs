namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quin es el teu Nom?");
        string nom = Console.ReadLine();

        Console.WriteLine("Quin es el teu Any de naixement?");
        string InputAny = Console.ReadLine();
        int AnyNaixement = Convert.ToInt16(InputAny);

        int AnyActual = 2025;
        //AnyActual = Convert.ToInt16(AnyActual);
        int edat = AnyActual - AnyNaixement;

        Console.WriteLine($"Hola {nom}!  Ja tens {edat} anys? ");
    }
}
