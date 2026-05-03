/* Crie uma classe Carro com:
campos privados: marca, ano, preco
propriedades públicas: Marca, Ano, Preco com get/set
no Main, crie um carro, preencha os dados pelo teclado e exiba na tela
*/

class Carro
{
    private string marca;
    private int ano;
    private double preco;
    public string Marca
    {
        get {return marca;}
        set {marca = value;}
    }
    public int Ano
    {
        get {return ano;}
        set {ano = value;}
    }
    public double Preco
    {
        get {return preco;}
        set {preco = value;}
    }
}

class Program
{
    static void Main(string[]args)
    {
        Carro c1 = new Carro();
        Console.WriteLine("Defina os dados do carro: ");
        Console.WriteLine("Marca: ");
        c1.Marca = Console.ReadLine();
        Console.WriteLine("Ano: ");
        c1.Ano = int.Parse(Console.ReadLine());
        Console.WriteLine("Preço: ");
        c1.Preco = double.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine($"Marca: {c1.Marca}");
        Console.WriteLine($"Ano: {c1.Ano}");
        Console.WriteLine($"Preço: {c1.Preco}");

        Console.ReadKey();
    }
    
}

