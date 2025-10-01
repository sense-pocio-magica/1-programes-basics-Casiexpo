namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("QUIN ES LA MIDA DEL PRIMER COSTAT?");
        var input1 = Console.ReadLine();
        float Costat_quadrat = Convert.ToInt16(input1);

        float resultat_del_perimetre = Costat_quadrat * 4;
        Console.WriteLine("EL PERIMETRE DEL QUADRAT ÉS:");
        Console.WriteLine(resultat_del_perimetre);
    }
}
