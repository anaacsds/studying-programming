/* Fa ̧ca fun ̧c ̃oes em C# que:
(a) calcule a soma dos n primeiros n ́umeros positivos;
(b) calcule a soma dos n primeiros n ́umeros positivos pares;
(c) calcule a soma dos n primeiros n ́umeros positivos  ́ımpares.
*/

class Program
{
    //static int = funções
    static int somaPositivos(int n) // Soma dos n primeiro números positivos
    {
        int soma = 0;
        for(int i = 1; i <= n; i++)
        {
            soma = soma + i;
        }
            return(soma);
    }
    static int somaPares(int n) // Soma dos n primeiros números positivos pares
    {
        int soma = 0;
        for(int i = 1; i <= n; i++)
        {
            soma = soma + 2*i;
        }
        return(soma);
    }
    static int somaImp(int n) // Soma dos n primeiros números positivos ímpares
    {
        int soma = 0;
        for(int i = 1; i <= n; i++)
        {
        soma = soma + (2 * i - 1);
        }
            return(soma);    
    }

// static void = procedimentos

    static void Main() // Main é declarada apenas uma vez
{
    int n;
    // Define n
    Console.WriteLine("Digite a quantidade de valores a serem somados: ");
    n = int.Parse(Console.ReadLine());

    Console.WriteLine($"A soma dos {n} primeiros números positivos é {somaPositivos(n)}");
    Console.WriteLine($"A soma dos {n} primeiros números positivos pares é {somaPares(n)}");
    Console.WriteLine($"A soma dos {n} primeiros números positivos ímpares é {somaImp(n)}");

}
}

