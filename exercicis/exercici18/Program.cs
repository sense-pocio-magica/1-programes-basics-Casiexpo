namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hora actual (1-12): ");
        int hora = Convert.ToInt16(Console.ReadLine());

        Console.Write("Hores a incrementar: ");
        int increment = Convert.ToInt16(Console.ReadLine());

        int novaHora = (hora + increment) % 12;
        if (novaHora == 0) novaHora = 12;

        Console.WriteLine($"D'aquí a {increment} hores, seran les {novaHora}h");
    }
}
