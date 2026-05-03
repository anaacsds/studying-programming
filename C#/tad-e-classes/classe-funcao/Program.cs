/* Crie:
Classe Produto
Nome
Preço

Depois faça uma função:

MostrarProduto(Produto p)

Ela deve mostrar:

Nome
Preço */

class Produto
{
    private string Nome;
    private double preco;
    public string nome
    {
        get{return Nome;}
        set{Nome = value;}
    }
    public double Preco
    {
        get{return preco;}
        set {preco = value;}
    }
}

class Program
{
    static void Main(string[] args)
    {
    Produto p = new Produto();
    p.nome = "Coca Cola 200ml";
    p.Preco = 2.50;
    MostrarProduto(p);   
    }

    static void MostrarProduto(Produto p)
    {
        Console.WriteLine($"Nome: {p.nome}");
        Console.WriteLine($"Preço: {p.Preco}");
    }

}