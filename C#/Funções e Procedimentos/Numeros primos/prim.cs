/*Faça uma função em C# que recebe como
argumento um número inteiro positivo e
verifica se é um número primo ou não.
*/

class Public
{
    static bool Primo (int n)
    {
        int i, divisores = 0;
        for(i = 1; i <= n; i ++)
        {
            if(n % i == 0)
            {
                divisores++;
            }
        }
        if (divisores == 2)
        {
            return (true);
        }
        else
        {
            return (false);
        }
    }
    static void Main (string [] agrs)
    {
        int n;
        Console.WriteLine("Informe um número: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine($"O número é primo?: {Primo(n)}");
    }
}