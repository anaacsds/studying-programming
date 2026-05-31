/*Faça uma função em C# que recebe como
argumento um número inteiro positivo e
retorna o seu número de divisores positivos.
*/

class Program
{
    static int DivisoresPositivos(int n)
    {
        int cont = 0;
        for(int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                cont++;
            }
        }
        return(cont);
    }




    static void Main(string [] args)
    {
        int n;        
        Console.WriteLine("Informe um número inteiro positivo: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine(DivisoresPositivos(n));
    }
}