/* Crie:
Classe Data com:
Dia
Mês
Ano
Classe Pessoa com:
Nome
DataNascimento
Depois:
Cadastre uma pessoa
e Mostre:
Nome
Data completa */

class Data
{
    private int dia;
    private int mes;
    private int ano;
    public int Dia
    {
        get {return dia;}
        set {dia = value;}
    }
    public int Mes
    {
        get {return mes;}
        set {mes = value;}
    }
    public int Ano
    {
        get{return ano;}
        set {ano = value;}
    }
}

class Pessoa
{
    private string nome;
    public string Nome
    {
        get{return nome;}
        set {nome = value;}
    }
    public Data Data = new Data();
}

class Program
{
    static void Main(string[]args)
    {
        Pessoa p1 = new Pessoa();
        Console.WriteLine("Nome da pessoa: ");
        p1.Nome = Console.ReadLine();
        Console.WriteLine($"Dia que {p1.Nome} nasceu: ");
        p1.Data.Dia = int.Parse(Console.ReadLine());
        Console.WriteLine($"Mês que {p1.Nome} nasceu: ");
        p1.Data.Mes = int.Parse(Console.ReadLine());
        Console.WriteLine($"Ano que {p1.Nome} nasceu: ");
        p1.Data.Ano = int.Parse(Console.ReadLine());     

        Console.Clear();

        Console.WriteLine($"Nome: {p1.Nome}");
        Console.WriteLine($"Data nascimento: {p1.Data.Dia}/{p1.Data.Mes}/{p1.Data.Ano}");

        Console.ReadKey();   
    }
}