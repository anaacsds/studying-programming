/* 3.	Faça uma adaptação no programa feito no exercício 2 para que ele:
a.	Suporte a entrada dos dados de 50 alunos (para testar, use os dados de 5 alunos). Use 
um vetor  para armazenar esses dados;
b.	Liste todos os alunos cadastrados através de uma função específica.
*/

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
        set
        {
            if (value > 0)
            {
                mes = value;
            }
        }
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
        
        Aluno[] alunos = new Aluno[50]; // vetor de 50 alunos
        // Aluno é a classe, a1 a referência e new Aluno o objeto

        for(int i = 0; i < 5; i ++ ) {
        alunos[i] = new Aluno(); // cria uma instancia pra cada aluno
        Console.WriteLine($"Nome do aluno {i+ 1}: ");
        alunos[i].Nome = Console.ReadLine();
        Console.WriteLine($"Email do aluno {i+ 1}: ");
        alunos[i].Email = Console.ReadLine();
        Console.WriteLine($"Telefone do aluno {i+ 1}: ");
        alunos[i].Telefone = int.Parse(Console.ReadLine());

        Console.WriteLine($"Dia de nascimento do aluno {i+ 1}: ");
        alunos[i].DataNascimento.Dia = int.Parse(Console.ReadLine());
        Console.WriteLine($"Mês de nascimento do aluno {i+ 1}: ");
        alunos[i].DataNascimento.Mes = int.Parse(Console.ReadLine());
        Console.WriteLine($"Ano de nascimento do aluno {i+ 1}: ");
        alunos[i].DataNascimento.Ano = int.Parse(Console.ReadLine());
        }

        Console.Clear();

        ListarAlunos(alunos, 5); // alunos é o vetor criado

    }
    static void ListarAlunos(Aluno[] alunos, int quantidade)
    {
        for(int i = 0; i < quantidade; i++) {
        Console.WriteLine($"Nome do aluno {i+ 1}: {alunos[i].Nome}");
        Console.WriteLine(" ");
        Console.WriteLine($"Email do aluno {i+ 1}: {alunos[i].Email}");
        Console.WriteLine(" ");
        Console.WriteLine($"Telefone do aluno {i+ 1}: {alunos[i].Telefone}");
        Console.WriteLine(" ");

        Console.WriteLine($"Data de Nascimento do aluno {i+ 1}: {alunos[i].DataNascimento.Dia}/{alunos[i].DataNascimento.Mes}/{alunos[i].DataNascimento.Ano}");
        Console.WriteLine(" ");
    }
    }
}
