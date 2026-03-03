/*
Faça uma função em C# para validar se um
número inteiro n está em uma faixa indicada
(entre i e j, inclusive).
*/

class Program
{
    static bool validar(int i, int j, int n)
    {
        if(n >= i && n <= j)
        return(true);
        else
        return(false);
    }


    static void Main(string[] args)
    {
        int i, j, n;
        Console.WriteLine("Digite um número correspondente a (i):" );
        i = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um número correspondente a (j):" );
        j = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um número correspondente a (n):" );
        n = int.Parse(Console.ReadLine());

            Console.WriteLine(validar(i, j, n));

    }
}