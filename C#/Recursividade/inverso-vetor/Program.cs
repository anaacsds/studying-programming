// Faça um programa que contenha uma função capaz de inverter um vetor fornecido por um usuário.

class Program
{
    static void Main(string[] args)
    {
        int t;

        Console.WriteLine("Digite o tamanho do vetor: ");
        t = int.Parse(Console.ReadLine());

        int[] v = new int[t];
        preenchV(v, new Random(), 0);

        Console.Write("Vetor original:  ");
        imprimeV(v, 0);

        int[] v1 = new int[t];
        invertV(v, v.Length - 1, v1, 0);  

        Console.Write("Vetor invertido: ");
        imprimeV(v1, 0);
    }

    static void preenchV(int[] v, Random x, int i)
    {
        if (i < v.Length)
        {
            v[i] = x.Next(1, 100);
            preenchV(v, x, i + 1);
        }
    }

    // lê v de trás pra frente, escreve v1 da esquerda pra direita
    static void invertV(int[] v, int i, int[] v1, int j)
    {
        if (i >= 0)                         
        {
            v1[j] = v[i];
            invertV(v, i - 1, v1, j + 1);  
        }
    }

    static void imprimeV(int[] v, int i)
    {
        if (i < v.Length)
        {
            Console.Write(v[i] + " ");
            imprimeV(v, i + 1);
        }
        else
            Console.WriteLine();
    }
}