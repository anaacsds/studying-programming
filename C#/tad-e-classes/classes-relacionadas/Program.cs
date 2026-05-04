/* Crie:
Classe Categoria
Código
Nome
Classe Produto
Nome
Preço
Categoria

Depois:

Crie 3 categorias
Crie 3 produtos ligados às categorias
Mostre:
Nome do produto
Nome da categoria */

class Categoria
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
}

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public Categoria Categoria = new Categoria();
}

class Program
{
    static void Main(string[]args)
    {
        Categoria [] categorias = new Categoria[3];
        Produto [] produtos = new Produto[3];

        for(int i = 0; i < categorias.Length; i++)
        {
            categorias[i] = new Categoria();

            Console.WriteLine($"Nome da categoria {i+1}: ");
            categorias[i].Nome = Console.ReadLine();
            Console.WriteLine($"Código da categoria {categorias[i].Nome}: ");
            categorias[i].Codigo = int.Parse(Console.ReadLine());
        }

        Console.Clear();

        for(int i = 0; i < produtos.Length; i ++)
        {
            produtos[i] = new Produto();
            int cat;   

            Console.WriteLine($"Digite o código da categoria que o produto {i+1} pertence? ");
            cat = int.Parse(Console.ReadLine());

        foreach (Categoria categoria in categorias) 
        {
            if (categoria.Codigo == cat)           
            {
                produtos[i].Categoria = categoria;  
            }
        }

            Console.WriteLine($"Nome do produto {i+1}: ");
            produtos[i].Nome = Console.ReadLine();
            Console.WriteLine($"Preço do produto {produtos[i].Nome}: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());
        }

        Console.Clear();

        for(int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"O produto {produtos[i].Nome} de preço {produtos[i].Preco} pertence a categoria {produtos[i].Categoria.Nome}");
        }

        Console.ReadKey();
    }
}
