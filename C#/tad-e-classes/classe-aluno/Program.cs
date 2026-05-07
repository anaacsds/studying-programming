/*1.	Faça um programa que defina uma estrutura ou classe contendo o Nome, Mail, Data de 
Nascimento e Telefone de um Aluno. Insira dados de exemplo nessa estrutura e depois liste seu conteúdo. */

class Aluno // declara classe
{
    //private guarda os dados e public acessa
    private string nome;
    private string email;
    private string dataNasc;
    private int telefone;

    //declara dados da classe
    public string Nome { 
        get {return nome; } // toda vez que precisar mostrar o valor 
        set { // set serve para colocar valor dentro (value)
            nome = value;
        }
    }
    public string Email
    {
        get {return email;}
        set {email = value;}
    }
    public string DataNasc
    {
        get {return dataNasc;}
        set {dataNasc = value;}
    }
    public int Telefone
    {
        get {return telefone;}
        set {telefone = value;}
    }

    // metodo para acessas todos os dados de uma classe
    public void MostrarDados()
    {
        Console.WriteLine(Nome);
        Console.WriteLine(Telefone);
    }
}

class Program
{
    static void Main(string[]args)
    {
        Aluno a1 = new Aluno(); //Aluno é a classe, a1 a referência e new Aluno o objeto
        Console.WriteLine($"Nome do aluno: ");
        a1.Nome = Console.ReadLine();
        Console.WriteLine($"Email do aluno: ");
        a1.Email = Console.ReadLine();
        Console.WriteLine($"Data de nascimento do aluno: ");
        a1.DataNasc = Console.ReadLine();
        Console.WriteLine($"Telefone do aluno: ");
        a1.Telefone = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine($"Nome do aluno: {a1.Nome}");
        Console.WriteLine($"Email do aluno: {a1.Email}");
        Console.WriteLine($"Data de Nascimento do aluno: {a1.DataNasc}");
        Console.WriteLine($"Telefone do aluno: {a1.Telefone}");

        Console.Clear();

        a1.MostrarDados(); // chama metodo da classe
    }
}