/* Faça uma função recursiva que mostre o menor número presente em um vetor de 20 posições.*/

class Program
{
    static void Main(string[]args)
    {
        int [] v = new int[20];
        int i = 0;

        preenchV(v, i);

        for(int j = 0; j < v.Length; j++)
        {
            Console.WriteLine($"Posição {j+1} - Elemento {v[j]}");
        }

        int menor = v[0];

        int m = menorNum(v, menor, i);

        Console.WriteLine($"O menor número do vetor é: {m}");

    }
    static int [] preenchV(int[]v, int i)
    {
        Random x = new Random();
        if (i < v.Length)
        {
            v[i] = x.Next(1,100);


            return preenchV(v, i + 1);
        }

        else
        return v;
    }
    static int menorNum(int[]v, int m, int i)
    {
        if(i < v.Length)
        {
            if(v[i] < m)
            m = v[i];

        return menorNum(v, m, i + 1);
        }   

        else
        return m;
    }
}