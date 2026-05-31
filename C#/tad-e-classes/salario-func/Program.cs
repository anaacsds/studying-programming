/* Fazer um programa para ler os dados de um funcionário (nome,
salário bruto e imposto). Em seguida, mostrar os dados do
funcionário (nome e salário líquido). Em seguida, aumentar o salário
do funcionário com base em uma porcentagem dada (somente o
salário bruto é afetado pela porcentagem) e mostrar novamente os
dados do funcionário.*/

    using System.Globalization;

    namespace Course {
    class Funcionario {
    public string Nome;
    public double SalarioBruto;
    public double Imposto;
    public double SalarioLiquido() {
    return SalarioBruto - Imposto;
    }
    public void AumentarSalario(double porcentagem) {
    SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
    }
    public override string ToString() {
    return Nome
    + ", R$ "
    + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
    }
    }

    class Program {

    static void Main(string[] args) {

    Funcionario func = new Funcionario();

    Console.Write("Nome: ");
    func.Nome = Console.ReadLine();
    Console.Write("Salario bruto: ");
    func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Imposto: ");
    func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine();

    Console.WriteLine("Funcionário: " + func);

    Console.WriteLine();

    Console.Write("Deseja aumentar o salário em qual porcentagem? ");
    double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    func.AumentarSalario(porcent);

    Console.WriteLine();

    Console.WriteLine("Dados atualizados: " + func);
    }
    }
    }