/* Faça uma função recursiva capaz de imprimir em tela a soma dos elementos de um vetor de 20 posições
composto de números aleatórios. */

class Program
{
    static void Main(string[]args)
    {
        int [] v = new int[20];
        Random x = new Random();
        int soma = 0, i = 0;

        for (int j = 0; j < v.Length; j++)
        v[j] = x.Next(1, 100);

        somaV(v, soma, i);

        Console.WriteLine($"Soma: {somaV(v, soma, i)}");
    }

    static int somaV(int [] v, int s, int i)
    {
       s += v[i];

       if (i < v.Length - 1)
        return somaV(v, s, i + 1);

        else
        return s;
    }
}