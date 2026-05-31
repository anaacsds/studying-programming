/* Faça um programa que leia um número inteiro n e forneça o resultado das séries:
S = 100 - 1 + 2 - 3 + 4 - 5 ... + n
*/

class Program
{
    static void Main(string[] args)
    {
        int n;

        Console.WriteLine("Defina um valor para n: ");
        n = int.Parse(Console.ReadLine());

        double valor = 100;

        for(int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
             valor += i;

             else
             valor -= i;
        }

        Console.WriteLine(valor);
    }
}