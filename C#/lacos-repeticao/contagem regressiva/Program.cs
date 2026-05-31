// Escreva um algoritmo que receba um número e mostre a contagem regressiva dele até zero, 
// apenas com os números pares.


class Program
{
    static void Main(string[] args)
    {
        int n;

        Console.WriteLine("Informe um número inteiro positivo: ");
        n = int.Parse(Console.ReadLine());

        int[] contp = contagemp(n);

        Console.Write($"Contagem regressiva de {n} até 0 (apenas números pares): ");
        for(int i = 0; i < contp.Length; i++)
        {
            Console.Write($"{contp[i]} , ");
            
        }

        Console.WriteLine(" ");

        int[] conti = contagemi(n);

        Console.Write($"Contagem regressiva de {n} até 0 (apenas números ímpares): ");
        for(int i = 0; i < conti.Length; i++)
        {
            Console.Write($"{conti[i]} , ");
            
        }
    }

    static int[] contagemp(int n)
    {
        int tamanho = (n / 2) + 1;
        int[] r = new int[tamanho];
        int pos = 0;

        for (int i = n; i >= 0; i--)
        {
            if (i % 2 == 0)
            {
                r[pos] = i;
                pos++;          
            }
        }
        return r;
    }
        static int[] contagemi(int n)
    {
        int tamanho = (n / 2) + 1;
        int[] r = new int[tamanho];
        int pos = 0;

        for (int i = n; i >= 0; i--)
        {
            if (i % 2 != 0)
            {
                r[pos] = i;
                pos++;          
            }
        }
        return r;
    }
}