/* Crie:
Classe Produto
Nome
Preço
Quantidade

Cadastre:

5 produtos

Mostre:

Nome
Valor total do produto
preço × quantidade */

class Produto
{
    private string Nome;
    private double Preco;
    private int Quant;
    public string nome
    {
        get {return Nome;}
        set {Nome = value;}
    }
    public double preco
    {
        get{return Preco;}
        set
        {
            if(value > 0)
            Preco = value;
        }
    }
    public int quant
    {
        get {return Quant;}
        set {Quant = value;}
    }
}

class Program
{
    static double CalcularTotal(Produto p)
{
    return p.preco * p.quant;
}
    static void Main(string[]args)
    {
        Produto [] produtos = new Produto[5];

        for(int i = 0; i < produtos.Length; i++)
        {
            produtos[i] = new Produto();

            Console.WriteLine($"Nome do produto {i+1}: ");
            produtos[i].nome = Console.ReadLine();
            Console.WriteLine($"Preço do produto {i+1}: ");
            produtos[i].preco = double.Parse(Console.ReadLine());
            Console.WriteLine($"Quantidade do produto {i+1}: ");
            produtos[i].quant = int.Parse(Console.ReadLine());
        }

        Console.Clear();

        for(int i = 0; i< produtos.Length; i++)
        {
            Console.WriteLine($"Nome: {produtos[i].nome} - Valor: {produtos[i].preco}");
        }
        for(int i = 0; i < produtos.Length; i++)
        {
            double pq = CalcularTotal(produtos[i]);
            Console.WriteLine($"... Preço x Quantidade - Produto {i+1}: {pq}");
        }
    }
}