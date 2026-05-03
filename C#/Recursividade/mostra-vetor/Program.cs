/*  Faça uma função recursiva que mostre o menor número presente em um vetor de 20 posições. */

class Program
{
    static void Main(string[]args)
    {
        int[]v = new int[20];
        int i = 0, menor = v[0];
    }
    static int preench(int[]v, int i)
    {
        Random x = new Random();
        
        if(v[i] > 0) {
        v[i] = x;
        }

        else {
        preench(v, ++i);
        }
    }
     static void mostra(int[]v, int i, int m)
    {
        if(v[i] > 0)
        {
            if(v[i] < m)
            {
                m = v[i];
            }
        }
        else
        {
            mostra(v, ++i, m);
        }

    }
}