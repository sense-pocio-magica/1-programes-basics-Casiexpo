namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("QUIN ES EL PRIMER NÚMERO?");
        var input1 = Console.ReadLine();
        float Numero_1 = Convert.ToInt16(input1);

        Console.WriteLine("QUIN ES EL SEGON NÚMERO?");
        var input2 = Console.ReadLine();
        float Numero_2 = Convert.ToInt16(input2);

        Console.WriteLine("QUIN ES EL TERCER NÚMERO?");
        var input3 = Console.ReadLine();
        float Numero_3 = Convert.ToInt16(input3);

        float Suma = Numero_1 + Numero_2 + Numero_3;
        float Mitjana = Suma / 3;
        Console.WriteLine("LA MITJANA ÉS:");
        Console.WriteLine(Mitjana);
    }
}
