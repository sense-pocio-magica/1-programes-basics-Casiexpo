namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        string nomProducte = "Ordinador portàtil";
        double preu = 799.99;
        bool enEstoc = false;

        Console.WriteLine($"Producte: {nomProducte}");
        Console.WriteLine($"Preu: {preu} €");
        Console.WriteLine($"En estoc: {(enEstoc ? "Sí" : "No")}");
    }
}
