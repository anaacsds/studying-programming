/* Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
velha.
*/

class Pessoa
{
    public string Nome;
    public int Idade;
}

class Program
{
    static void Main(string[]args)
    {
        Pessoa p1, p2; 
        p1 = new Pessoa();
        p2 = new Pessoa();

        Console.WriteLine("Nome da primeira pessoa: ");
        p1.Nome = Console.ReadLine();
        Console.WriteLine("Idade da primeira pessoa: ");
        p1.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Nome da segunda pessoa: ");
        p2.Nome = Console.ReadLine();
        Console.WriteLine("Idade da segunda pessoa: ");
        p2.Idade = int.Parse(Console.ReadLine());

        Console.Clear();

        if(p1.Idade > p2.Idade)
        Console.WriteLine($"{p1.Nome} é mais velho(a)!");
        else
        Console.WriteLine($"{p2.Nome} é mais velho(a)!");

        Console.ReadKey();
    }
}