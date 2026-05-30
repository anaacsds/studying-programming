/* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste 
círculo com quatro casas decimais conforme exemplos.
Fórmula:  = .
Considere o valor de π = 3.14159 */

class Program
{
    static void Main (string[] args) {
        double pi = 3.14159;

        Console.WriteLine($"Valor do raio: ");
        double raio = double.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine($"A área do círculo é: {CalArea(pi, raio):F4}"); // F4 mostra 4 casas decimais

        Console.ReadKey();

    }
    static double CalArea (double pi, double raio)
    {
        return pi * (raio * raio);
    }
}