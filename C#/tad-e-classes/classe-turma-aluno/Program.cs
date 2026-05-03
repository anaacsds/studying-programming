/* Crie:
classe Turma com Codigo e Nome
classe Aluno com Nome e uma Turma dentro
cadastre 3 turmas e 5 alunos
no cadastro do aluno, pergunte o código da turma e busque no vetor pra vincular
liste cada aluno mostrando o nome da turma dele */

class Turma
{
    private int codigo;
    private string nome;
    public int Codigo
    {
        get {return codigo;}
        set {codigo = value;}
    }
    public string Nome
    {
        get {return nome;}
        set {nome = value;}
    }
}
class Aluno
{
    private string nome;
    public string Nome
    {
        get {return nome;}
        set {nome = value;}
    }
    public Turma Turma = new Turma();
}

class Program
{
    static void Main(string[]args)
    {
        Turma [] turma = new Turma[3];
        Aluno [] aluno = new Aluno [5];

        for(int i = 0; i < 3; i++ )
        {
            turma[i] = new Turma(); 

            Console.WriteLine($"Código da turma {i+1}: ");
            turma[i].Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Nome da turma {i+1}: ");
            turma[i].Nome = (Console.ReadLine());
        }
        
        Console.Clear();

        for(int i = 0; i < 5; i++)
        {
            aluno[i] = new Aluno(); // cria o objeto
            
            int cod;

            Console.WriteLine($"Nome do aluno {i+1}: "); 
            aluno[i].Nome = Console.ReadLine();          
            
            Console.WriteLine($"Qual o código da turma do aluno {i+1}? ");
            cod = int.Parse(Console.ReadLine());

            for (int j = 0; j < 3; j ++) {
            if(turma[j].Codigo == cod) {
            aluno[i].Turma = turma[j];
            }
            }
        }

        Console.Clear();

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Aluno: {aluno[i].Nome} - Turma: {aluno[i].Turma.Nome} (Código - {aluno[i].Turma.Codigo})");
        }
    }
}