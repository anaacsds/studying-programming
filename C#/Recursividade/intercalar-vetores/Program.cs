/* Dados dois vetores a = [1, 3, 5] e b = [2, 4, 6], crie void intercala(int[] a, 
int[] b, int[] r, int i, int j, int k) que preencha r alternando elementos: [1, 2, 3, 4, 5, 6].

Assuma que os dois vetores têm o mesmo tamanho. Imprima o resultado. */

class Program
{
    static void Main(string[]args)
    {
        int [] a = {1, 3, 5};
        int [] b = {2, 4, 6};
        int [] r = new int [a.Length + b.Length];

        intercala(a, b, r, 0, 0, 0);
    }
    static void intercala(int[]a, int[]b, int[]r, int i, int j, int k)
    {
        // caso base
        if (i >= a.Length)            
            return;
            
        r[k]     = a[i];               // Posição par de r recebe elemento de a
        r[k + 1] = b[j];               // Posição ímpar de r recebe elemento de b

        intercala(a, b, r, i + 1, j + 1, k + 2);   // k avança 2 preencheu duas posições
    }
}