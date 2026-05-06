/* Crie int contaNum(int[] v, int num, int i) que retorne quantas vezes num aparece em v.

Leia o vetor e o número pelo teclado. Imprima o resultado. */

class Program
{
    static void Main(string[]args) {
    Console.WriteLine("Defina o tamanho do vetor: ");
    int t = int.Parse(Console.ReadLine());

    int [] v = new int[t];
    int i = 0;

    Console.Clear();

    Console.WriteLine($"Preencha o vetor: ");
    for(int j = 0; j < v.Length; j++)
        {
            Console.WriteLine($"Posição {j} - Elemento: ");
            v[j] = int.Parse(Console.ReadLine());
        }

    Console.Clear();

    Console.WriteLine($"Digite o número que quer saber quantas vezes aparece no vetor: ");
    int num = int.Parse(Console.ReadLine());

    Console.WriteLine($"{num} aparece: {contaNum(v, i, num)} vezes");

    Console.ReadKey();
    }
    static int contaNum(int [] v, int i, int num)
    {
        if (i >= v.Length)                         
            return 0;

        if (v[i] == num)
            return 1 + contaNum(v, i + 1, num);   

        return contaNum(v, i + 1, num);
    }
}