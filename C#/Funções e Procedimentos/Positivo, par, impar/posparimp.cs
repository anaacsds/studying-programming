/* Fa ̧ca procedimentos em C# que:
(a) escreva na tela os n primeiros n ́umeros positivos;
(b) escreva na tela os n primeiros n ́umeros positivos pares;
(c) escreva na tela os n primeiros n ́umeros positivos  ́ımpares.
*/

class Program
{
    static void mostraPositivos(int n)
    {
        for(int i = 1; i <= n; i++)
        {
            Console.Write($"{i} - ");
        }
    }
    static void mostraPares(int n) 
    {
        for(int i = 1; i <= n; i++)
        {
            Console.Write($"{(2*i)} - ");
        }
    }
    static void mostraImp(int n) 
    {
        for(int i = 1; i <= n; i++)
        {
        Console.Write($"{(2 * i - 1)} - ");
        }
    }

    static void Main() // Main é declarada apenas uma vez
{
    int n;
    // Define n

    Console.WriteLine("Digite a quantidade de valores a serem mostrados: ");
    n = int.Parse(Console.ReadLine());

    Console.WriteLine($"Primeiros números postivos: {mostraPositivos(n)}");
    mostraPositivos(n);
}
}

