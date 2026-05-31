/* Faça um procedimento em C# que recebe
como argumento um número inteiro positivo e
escreva os seus divisores positivos.
*/

class Program
{

    static void Divisores (int n)
    {
        for(int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            Console.WriteLine(i);
        }
    }

        static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Informe um valor: ");
        n = int.Parse(Console.ReadLine());

        Divisores(n);
    }

}