/* Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
médio dos funcionários.
*/ 

class Func
{
    public string nome;
    public double salario;
}

class Program
{
    static void Main(string[]args ){ 
    Func f1, f2;
    f1 = new Func();
    f2 = new Func();
    
        Console.WriteLine("Nome do(a) primeiro(a) funcionário(a): ");
        f1.nome = Console.ReadLine();
        Console.WriteLine("Salário do(a) primeiro(a) funcionário(a): ");
        f1.salario = double.Parse (Console.ReadLine());

        Console.WriteLine("Nome do(a) segundo(a) funcionário(a): ");
        f2.nome = Console.ReadLine();
        Console.WriteLine("Salário do(a) segundo(a) funcionário(a): ");
        f2.salario = double.Parse (Console.ReadLine());

        Console.Clear();

        Console.WriteLine($"O salário médio dos funcionários é: {(f1.salario + f2.salario) / 2}");
    }
}