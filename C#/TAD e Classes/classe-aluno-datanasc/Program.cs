/* 1.	Faça um programa que defina uma estrutura ou classe contendo o Nome, Mail, Data de 
Nascimento e Telefone de um Aluno. Insira dados de exemplo nessa estrutura e depois liste seu conteúdo. 
2.	Defina também uma estrutura, ou classe, para suportar o campo Data de Nascimento, que deverá 
conter os subcampos Dia, Mês e Ano. */

class DataNasc
{
    private int dia;
    private int mes;
    private int ano;

    public int Dia
    {
        get {return dia;}
        set
        {
            if (value > 0)
            {
                dia = value;
            }
        }
    }
        public int Mes
    {
        get {return mes;}
        set{mes = value;}
    }
        public int Ano
    {
        get {return ano;}
        set
        {
            if (value > 0)
            {
                ano = value;
            }
        }
    }
    
}

class Aluno // declara classe
{
    public DataNasc DataNascimento { get; set; } = new DataNasc(); // aluno possui uma data de nascimento
                                                                    //objeto DataNasc criado
    //private guarda os dados e public acessa
    private string nome;
    private string email;
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
    public int Telefone
    {
        get {return telefone;}
        set {telefone = value;}
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
        Console.WriteLine($"Telefone do aluno: ");
        a1.Telefone = int.Parse(Console.ReadLine());

        Console.WriteLine($"Dia de nascimento do aluno: ");
        a1.DataNascimento.Dia = int.Parse(Console.ReadLine());
        Console.WriteLine($"Mês de nascimento do aluno: ");
        a1.DataNascimento.Mes = int.Parse(Console.ReadLine());
        Console.WriteLine($"Ano de nascimento do aluno: ");
        a1.DataNascimento.Ano = int.Parse(Console.ReadLine());


        Console.Clear();

        Console.WriteLine($"Nome do aluno: {a1.Nome}");
        Console.WriteLine($"Email do aluno: {a1.Email}");
        Console.WriteLine($"Telefone do aluno: {a1.Telefone}");

        Console.WriteLine($"Data de Nascimento: {a1.DataNascimento.Dia}/{a1.DataNascimento.Mes}/{a1.DataNascimento.Ano}");


    }
}