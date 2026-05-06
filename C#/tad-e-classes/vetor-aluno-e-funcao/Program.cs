/*Defina uma struct Aluno com os campos Nome (string), Email (string), DataNascimento
 (string) e Telefone (string).

No Main, crie uma variável do tipo Aluno, preencha com dados de exemplo e imprima todos 
os campos no console.*/

class Aluno
{
    private string Nome;
    private string Email;
    private string DataNascimento;
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
    public string datanasc
    {
        get {return DataNascimento;}
        set{DataNascimento = value;}
    }
     public string telefone
    {
        get {return Telefone;}
        set{Telefone = value;}
    }
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
        Console.WriteLine($"Digite a data de nascimento do aluno: ");
        aluno.datanasc = Console.ReadLine();
        Console.WriteLine($"Digite o telefone do aluno: ");
        aluno.telefone = Console.ReadLine();

        Console.Clear();

        Console.WriteLine($"Aluno(a): {aluno.nome} - Email: {aluno.email} - Data de nascimento: {aluno.datanasc} - Telefone {aluno.telefone}");
    }
}


/* Crie uma struct Data com os campos Dia, Mes e Ano (todos int).

Altere a struct Aluno do exercício anterior para que o campo DataNascimento seja do 
tipo Data em vez de string.

Preencha e imprima os dados de um aluno, incluindo a data formatada como dd/mm/aaaa.*/















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