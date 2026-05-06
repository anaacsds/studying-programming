/* Crie uma função recursiva int somaV(int[] v, int i) que retorne a soma de todos os 
elementos do vetor.

O vetor deve ser preenchido com valores aleatórios entre 1 e 50 no Main. Imprima o vetor 
e a soma no console.*/

class Program
{
    static void Main(string[]args)
    {
        int [] v = new int [50];
        int i = 0;
        Random x = new Random();

        preenchV(v, i, x);
        for(int j = 0; j < v.Length; j++)
        {
            if(j == v.Length - 1)
            Console.WriteLine($"{v[j]}");
            else
            Console.Write($"{v[j]} - ");
        }
        Console.WriteLine() ;

        Console.WriteLine($"A soma é: {somaV(v, i)}");

        Console.ReadKey();
    }
    static int[] preenchV(int [] v, int i, Random x)
    {
        if(i == v.Length) 
        return v;

        else
        {
            v[i] = x.Next(1,50);

            return preenchV(v, i + 1, x);
        }
    }
    static int somaV(int[]v, int i)
    {
        if(i < v.Length)
        return v[i] + somaV(v, i + 1);

        else 
        return 0;
    }
}