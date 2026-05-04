/* Classe Turma        → Codigo, Nome
Classe Aluno        → Nome, Turma

- Crie 2 turmas
- Crie 3 alunos vinculados a uma turma pelo código
- Mostre: Nome do aluno | Nome da turma */

using System.Xml.Serialization;

class Turma
{
    private int Codigo;
    private string Nome;
    public int codigo
    {
        get {return Codigo;}
        set
        {
            if(value > 0)
            Codigo = value;
        }
    }
    public string nome
    {
        get {return Nome;}
        set{Nome = value;}
    }
}

class Aluno
{
    private string Nome;
    public string nome
    {
        get { return Nome; }
        set { Nome = value; }
    }

    public Turma Turma = new Turma();
}

class Program
{
    static void Main(string[]args)
    {
        Turma []turma = new Turma[2];
        Aluno []aluno = new Aluno[3];
        int i = 0;

        while(i < turma.Length)
        {
            turma[i] = new Turma();

            Console.WriteLine($"Nome da turma: ");
            turma[i].nome = Console.ReadLine();
            Console.WriteLine($"Código da turma {turma[i].nome}: ");
            turma[i].codigo = int.Parse(Console.ReadLine());

            i++;
        }

        i = 0;

        while(i < aluno.Length)
        {
            aluno[i] = new Aluno();

            Console.WriteLine($"Nome do aluno: ");
            aluno[i].nome = Console.ReadLine();

            Console.WriteLine($"Qual código da turma o(a) {aluno[i].nome} pertence: ");
            int cod = int.Parse(Console.ReadLine());

            foreach (Turma t in turma) // t = objeto Turma inteiro
                                        // para cada objeto Turma do array turmas, chame-o de t
                                        // para cada t em turma...
            {
                if(cod == t.codigo)
                {
                    aluno[i].Turma = t;
                }
            }

            i++;
        }

        Console.Clear();

        for (i = 0; i < aluno.Length; i++)
        {
            Console.WriteLine($"Aluno(a) {aluno[i].nome} pertence à turma {aluno[i].Turma.nome} de código {aluno[i].Turma.codigo}.");
        }
    }
}