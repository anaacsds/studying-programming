/* Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
para ser responsável pelos cálculos.
*/

using System.Globalization;


namespace Course {

    class ConversorDeMoeda {

    public static double Iof = 6.0;

    public static double DolarParaReal(double quantia, double cotacao) {
        double total = quantia * cotacao;
    return total + total * Iof / 100.0;
    }
    }

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Qual é a cotação do dólar? ");
        double cot = double.Parse(Console.ReadLine());

        Console.WriteLine("Quantos dólares você vai comprar? ");
        double dol = double.Parse(Console.ReadLine());

        double valor = ConversorDeMoeda.DolarParaReal(dol, cot);

        Console.WriteLine("Valor a ser pago em reais: " + valor.ToString("F2", CultureInfo.InvariantCulture) );
    }
}
}