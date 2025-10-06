namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra el primer número: ");
        int num_1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Entra el segon número: ");
        int num_2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine($"{num_1} + {num_2} = {num_1 + num_2}");
        Console.WriteLine($"{num_1} - {num_2} = {num_1 - num_2}");
        Console.WriteLine($"{num_1} * {num_2} = {num_1 * num_2}");
        Console.WriteLine($"{num_1} / {num_2} = {num_1 / num_2}  i en sobre/n {num_1 % num_2}");
    }
}
