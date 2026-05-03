/* Crie:
classe Endereco com Rua e Cidade
classe Pessoa com Nome e um Endereco dentro dela
no Main, preencha os dados e exiba na tela */

class Endereco
{
    private string rua;
    private string cidade;
    public string Rua
    {
        get {return rua;}
        set {rua = value;}
    }
    public string Cidade
    {
        get {return cidade;}
        set {cidade = value;}
    }
}
class Pessoa
{
    public Endereco Endereco = new Endereco();
    private string nome;
    public string Nome
    {
        get {return nome;}
        set {nome = value;}
    }
}

class Program
{
    static void Main(string[]args)
    {
        Pessoa p1 = new Pessoa();
        Console.WriteLine("Nome da pessoa: ");
        p1.Nome = Console.ReadLine();
        Console.WriteLine($"Rua da {p1.Nome}: ");
        p1.Endereco.Rua = Console.ReadLine();
        Console.WriteLine($"Cidade da pessoa {p1.Nome}: ");
        p1.Endereco.Cidade = Console.ReadLine();

        Console.Clear();

        Console.WriteLine($"Nome: {p1.Nome}");
        Console.WriteLine($"Rua: {p1.Endereco.Rua}");
        Console.WriteLine($"Cidade: {p1.Endereco.Cidade}");

        Console.ReadKey();
    }
}