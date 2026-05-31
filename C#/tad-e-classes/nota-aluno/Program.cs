/* Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
este problema.
*/
    using System.Globalization;

    namespace Course {
    class Aluno {
    public string Nome;
    public double Nota1, Nota2, Nota3;
    public double NotaFinal() {
    return Nota1 + Nota2 + Nota3;
    }
    public bool Aprovado() {
    if (NotaFinal() >= 60.0) {
    return true;
    }
    else {
    return false;
    }
    }
    public double NotaRestante() {
    if (Aprovado()) {
    return 0.0;
    }
    else {
    return 60.0 - NotaFinal();
    }
    }
    }

    class Program {
    static void Main(string[] args) {
    Aluno aluno = new Aluno();

    Console.Write("Nome do aluno: ");
    aluno.Nome = Console.ReadLine();

    Console.WriteLine("Digite as três notas do aluno:");
    aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
    if (aluno.Aprovado()) {
    Console.WriteLine("APROVADO");
    }
    else {
    Console.WriteLine("REPROVADO");
    Console.WriteLine("FALTARAM "
    + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
    }
    }
    }
    }