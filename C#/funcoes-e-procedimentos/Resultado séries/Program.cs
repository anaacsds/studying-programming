/*Faça um programa que leia um número inteiro n e forneça o resultado das séries:
s = 1/2 + 2/3 + 3/4 ... + n-1/n
*/

class Program
{
    static void Main (string[] args )
    {
        double n;

        Console.WriteLine("Defina um valor para n: ");
        n = double.Parse(Console.ReadLine());

        double s = 0;

        for(int i = 1; i < n; i ++)
            s += (double)i / ( i + 1 );

        Console.WriteLine(s);
    }
}