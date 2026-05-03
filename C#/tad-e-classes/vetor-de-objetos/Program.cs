/* Crie:
Classe Aluno
Nome
Nota

Depois:

Crie um vetor de 5 alunos
Cadastre todos
Mostre todos */

class Aluno
{
    private string Nome;
    private double Nota;
    public string nome
    {
        get {return Nome;}
        set {Nome = value;}
    }
    public double nota
    {
        get {return Nota;}
        set
        {
            if(value > 0)
            Nota = value;
        }
    }
}

class Program
{
    static void Main(string[]args)
    {
        Aluno[] alunos = new Aluno[5];
        // Aluno é a classe, alunos a referencia e new Aluno o objeto, [] cria vetor de ... posições

        for(int i = 0; i < alunos.Length; i ++)
        {
            alunos[i] = new Aluno(); // cria o objeto na posição i

            Console.WriteLine($"Nome do aluno(a): ");
            alunos[i].nome = Console.ReadLine(); 
            //alunos da posição i, do tipo de dado "nome", recebe...
            Console.WriteLine($"Nota do(a) {alunos[i].nome}: ");
            alunos[i].nota = double.Parse(Console.ReadLine());
        }

        Console.Clear();

        for(int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Nome: {alunos[i].nome} - Nota: {alunos[i].nota}");
        }

        Console.ReadKey();

    }
}