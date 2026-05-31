/* Faça um programa que mostre os n primeiros termos da Série de Fibonacci, com n
obrigatoriamente maior que 2:
1 - 1 - 2 - 3 - 5 - 8 - 13 - 21 ...
*/

class Program
{
    static void Main(string[]args)
    {
        int n;

        do {
        Console.WriteLine("Defina um valor para n (que seja maior que 2): ");
        n = int.Parse(Console.ReadLine());
        }
        while(n <= 2);

        Console.WriteLine(" ");

        int a = 1, b = 1;
        Console.Write($"{a} - {b} - ");

        for(int i = 3; i < n; i++)
        {
            int proximo = a + b;
            Console.Write($"{proximo} - ");
            a = b;
            b = proximo;
        }
    }
}