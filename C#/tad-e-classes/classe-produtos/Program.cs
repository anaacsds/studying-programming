/* Crie uma classe chamada Produto com os campos Nome do Produto, Código da Categoria do Produto, 
Preço Unitário e Quantidade em Estoque. Crie também outra classe chamada Categoria, que contenha os 
campos Código e Descrição da Categoria. Considere que serão cadastradas várias Categorias de Produtos e, 
depois, diversos Produtos, cada um deles pertencentes a uma Categoria. */

class Categoria
{
    private int Codigo;
    private string Descricao;
    public int codigo
    {
        get {return Codigo;}
        set {Codigo = value;}
    }
    public string descricao
    {
        get {return Descricao;}
        set {Descricao = value;}
    } 
}

class Produto
{
    private string NomeProduto;
    private int CodigoProduto;
    private double Preco;
    private int Quant;

    public Categoria categorias { get; set; } = new Categoria();

    public string nomeProduto {
        get{return NomeProduto;}
        set{NomeProduto=value;}
    }
    public int codigoProduto {
        get {return CodigoProduto;}
        set {CodigoProduto = value;}
    }
    public double preco{
        get {return Preco;}
        set {Preco = value;}
    }
    public int quant {
        get{ return Quant;}
        set {Quant = value;}
    }
}

/*
a.	Crie uma função para a inclusão de dados de Categorias e para inclusão de Produtos em estoque; 
b.	Elabore uma função que receba os vetores de dados e mostre um relatório contendo o Nome do Produto, 
a Descrição da Categoria desse Produto, o Preço Unitário e a Quantidade em Estoque; 
c.	Mostre o Inventário do Estoque, ou seja, todo o valor (Quantidade em Estoque x Preço Unitário) 
contido no Estoque. */

class Program
{
    static void Main(string[] args)
{
    Categoria[] categorias = new Categoria[6]; // cria um vetor com espaço para 6 categorias
    Produto[] produtos = new Produto[6];

    CadastrarCategorias(categorias, 3);  // a.
    CadastrarProdutos(produtos, categorias, 6); // a.
    ListarProdutos(produtos, categorias);  // b.
    MostrarInventario(produtos, 6);      // c.
}
    static void CadastrarCategorias(Categoria[] categorias, int quantidade) 
    // Categoria[] categorias recebe a prateleira de categorias criada no Main

{
    for (int i = 0; i < quantidade; i++)
    {
        categorias[i] = new Categoria(); // Pega o i da prateleira e cria uma categoria dentro dela
        Console.Write($"Código da categoria {i+1}: ");
        categorias[i].codigo = int.Parse(Console.ReadLine());
        Console.Write($"Descrição da categoria {i+1}: ");
        categorias[i].descricao = Console.ReadLine();
    }
}
    static void CadastrarProdutos(Produto[] produtos, Categoria [] categorias, int quantidade)
    {
        for(int i = 0; i < quantidade; i++) {
        produtos[i] = new Produto();
        Console.WriteLine($"Nome do produto {i+1}: ");
        produtos[i].nomeProduto = Console.ReadLine();
        Console.WriteLine($"Código do produto {i+1}: ");
        produtos[i].codigoProduto = int.Parse(Console.ReadLine());
        Console.WriteLine($"Preço do produto {i+1}: ");
        produtos[i].preco = double.Parse(Console.ReadLine());
        Console.WriteLine($"Quantidade de produto {i+1}: ");
        produtos[i].quant = int.Parse(Console.ReadLine());
        }
    }
    static void ListarProdutos (Produto []produtos, Categoria [] categorias)
    {
        for(int i = 0; i < produtos.Length;i ++) {
        Console.WriteLine($"Nome do produto {i + 1}: {produtos[i].nomeProduto}");
        // categoria do produto:
        Console.WriteLine($"Descrição da categoria do produto {i + 1}: {produtos[i].categorias.descricao}");
        Console.WriteLine($"Preço do produto {i + 1}: {produtos[i].preco}");
        Console.WriteLine($"Quantidade do produto {i + 1}: {produtos[i].quant}");
        }
    }
    static void MostrarInventario(Produto[] produtos, int quantidade)
    {
        double inv = 0;
        for(int i=0; i < quantidade; i++) {
        inv += produtos[i].quant * produtos[i].preco;
        }
        Console.WriteLine($"Valor total do inventário: R$ {inv}");
    }
}