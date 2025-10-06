namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quin es el teu Carrer?");
        string Carrer = Console.ReadLine();

        Console.WriteLine("Quin es el teu Nº de casa?");
        var input1 = Console.ReadLine();
        float numero_de_casa = Convert.ToInt16(input1);

        Console.WriteLine("Quina es la teva població?");
        string Poblacio = Console.ReadLine();

        Console.WriteLine("Quin es el teu Codi Postal?");
        var input2 = Console.ReadLine();
        float Codi_postal = Convert.ToInt16(input2);

        Console.WriteLine($"Vius al carrer {Carrer}, numero {numero_de_casa}, a la població de {Poblacio}, amb codi postal:{Codi_postal}");
    }
}
