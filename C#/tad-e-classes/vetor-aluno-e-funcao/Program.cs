/*Defina uma struct Aluno com os campos Nome (string), Email (string), DataNascimento
 (string) e Telefone (string).

No Main, crie uma variável do tipo Aluno, preencha com dados de exemplo e imprima todos 
os campos no console.*/

/* Crie uma struct Data com os campos Dia, Mes e Ano (todos int).

Altere a struct Aluno do exercício anterior para que o campo DataNascimento seja do 
tipo Data em vez de string.

Preencha e imprima os dados de um aluno, incluindo a data formatada como dd/mm/aaaa.*/

using System.Runtime.CompilerServices;

class Data
{
    private int Dia;
    private int Mes;
    private int Ano;
    public int dia
    {
        get {return Dia;}
        set {Dia = value;}
    }
        public int mes
    {
        get {return Mes;}
        set {Mes = value;}
    }
        public int ano
    {
        get {return Ano;}
        set {Ano = value;}
    }
}
class Aluno
{
    private string Nome;
    private string Email;
    private string Telefone;
    public string nome
    {
        get {return Nome;}
        set{Nome = value;}
    }
        public string email
    {
        get {return Email;}
        set{Email = value;}
    }
     public string telefone
    {
        get {return Telefone;}
        set{Telefone = value;}
    }
    public Data data = new Data();
    }

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        Console.WriteLine($"Digite o nome do aluno: ");
        aluno.nome = Console.ReadLine();
        Console.WriteLine($"Digite o email do aluno: ");
        aluno.email = Console.ReadLine();
        Console.WriteLine($"Digite o telefone do aluno: ");
        aluno.telefone = Console.ReadLine();
        Console.WriteLine($"Digite o dia de nascimento do aluno: ");
        aluno.data.dia = int.Parse(Console.ReadLine());
        Console.WriteLine($"Digite o mês de nascimento do aluno: ");
        aluno.data.mes = int.Parse(Console.ReadLine());
        Console.WriteLine($"Digite o ano de nascimento do aluno: ");
        aluno.data.ano = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine($"Aluno(a): {aluno.nome} - Email: {aluno.email} - Telefone {aluno.telefone} - Data de nascimento: {aluno.data.dia} / {aluno.data.mes} / {aluno.data.ano}");
    }
}

/* Usando as structs Aluno e Data do exercício anterior, declare um vetor Aluno[] turma = 
new Aluno[50].

Leia os dados de 5 alunos pelo teclado e armazene no vetor.

Crie uma função void listaAlunos(Aluno[] turma, int total) que imprima todos os alunos 
cadastrados com seus dados formatados. */













/*Adicione ao programa do exercício 03 uma função int buscaAluno(Aluno[] turma, int total, 
string nome) que retorne o índice do aluno com o nome buscado, ou -1 se não encontrado.

Leia um nome pelo teclado, chame a função e imprima os dados do aluno encontrado, ou uma mensagem 
de erro se não existir.
*/
















/* Adicione ao programa do exercício 03 uma função void ordenaAlunos(Aluno[] turma, int 
total) que ordene os alunos em ordem alfabética pelo nome usando bubble sort.

Imprima a turma antes e depois da ordenação para confirmar o resultado.*/