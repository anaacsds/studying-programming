/* Faça uma função recursiva que conte quantos números pares um vetor de 10 posições 
de números aleatórios
possui. */

class Program
{
    static void Main(string[]args )
    {
        int [] v = new int [10];
        Random x = new Random();

        preenchV(v, x, 0);
        for(int i = 0; i < v.Length; i++)
        {
            if(i == v.Length - 1)
            Console.WriteLine(v[i]);

            else
            Console.Write($"{v[i]} - ");
        }

        Console.WriteLine();
        Console.WriteLine(numPar(v, 0));
    }
    static int [] preenchV(int [] v, Random x, int i)
    {
        if(i < v.Length)
        {
            v[i] = x.Next(1, 50);

            return preenchV(v, x, i + 1);
        }
        else 
        return v;
    }
    static int numPar(int [] v, int i)
    {
        if(i < v.Length)
        {
            if(v[i] % 2 == 0)
            return 1 + numPar(v, i + 1);
            
            else
            return 0 + numPar(v, i + 1);;
    }
        else
        return 0;
}
        }

