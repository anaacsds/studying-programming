/* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de 
cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule 
e mostre o valor a ser pago */

class Program
{
    static void Main (string[] args)
    {
        int cod1, num1, cod2, num2;
        double valor1, valor2;

        Console.WriteLine($"Código da peça 1: ");
        cod1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Número de peças 1: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Valor da peça 1: ");
        valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Código da peça 2: ");
        cod2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Número de peças 2: ");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Valor da peça 2: ");
        valor2 = double.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine($"Valor a pagar: ");
        Console.WriteLine($"{(num1 * valor1) + (num2 * valor2)}");

        Console.ReadKey();
    }
}