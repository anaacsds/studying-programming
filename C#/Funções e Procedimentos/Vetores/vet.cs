/*
Fa ̧ca em C# as fun ̧c ̃oes e procedimentos abaixo:
(a) ContaMenores: recebe como argumento um vetor de n ́umeros inteiros V e um n ́umero
inteiro x, calcula e devolve como resultado a quantidade de n ́umeros inteiros menores que
x presentes no vetor;
*/

class Program
{
    static int ContaMenores(int [] V, int x)
    {
        int cont=0, i;
        for (i = 0; i < V.Length; i++)
        {
            if (V[i] < x)
            {
                cont++;
            }
        }
        return(cont);
    }


/*
(b) ContaMaiores: recebe como argumento um vetor de n ́umeros inteiros V e um n ́umero
inteiro x, calcula e devolve como resultado a quantidade de n ́umeros inteiros maiores que
x presentes no vetor;
*/

    static int ContaMaiores(int [] V, int x)
    {
        int i, cont=0;
        for (i = 0; i < V.Length; i ++)
        {
            if (V[i] > x)
            {
                cont++;
            }
        }
        return(cont);
    }


/*
(c) CriaVetorPositivos: recebe como argumento um vetor de n ́umeros inteiros V , cria um
vetor de n ́umeros inteiros VP que contenha apenas os n ́umeros positivos presentes em V e
devolve o vetor VP como resultado. O vetor VP deve ter apenas o tamanho necess ́ario;
*/

    static int[] CriarVetorPositivos (int [] V)
    {
        int cont = 0, i, pos= 0;
        for(i = 0; i < V.Length; i++)
        {
            if (V[i] > 0)
            cont++;
        }

        int [] Vp = new int [cont];

        for(i = 0; i < V.Length; i ++)
        {
            if (V[i] > 0)
            {
                Vp[pos] = V[i];
                pos++;
            }
        }

        return(Vp);
    }

/*
(d) CriaVetorNegativos: recebe como argumento um vetor de n ́umeros inteiros V , cria um
vetor de n ́umeros inteiros VN que contenha apenas os n ́umeros negativos presentes em V
e devolve o vetor VN como resultado. O vetor VN deve ter apenas o tamanho necess ́ario;
*/

    static int [] CriaVetorNegativos (int [] V)
    {
        int [] Vn;
        int i, cont = 0, pos = 0;
        for ( i = 0; i < V.Length; i++)
        {
            if ( V[i] < 0)
            {
                cont++;
            }
        }
        Vn = new int[cont];

        for(i = 0; i < V.Length; i++)
        {
            if (V[i] < 0)
            {
                Vn[pos] = V[i];
                pos++;
            }
        }
        return (Vn);
    }

/*
(e) ExibeVetor: recebe como argumento um vetor de n ́umeros inteiros V e exibe seus elemen-
tos na tela
*/

    static void Main(string[] args)
    {
        int[] v;
        int n, x;
        
        Console.Write("Defina o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Defina o valor de x: ");
        x = int.Parse(Console.ReadLine());

        v = new int[n];

        for (int i = 0; i < v.Length; i++)
        {
            Console.Write($"Informe o {i + 1}º número: ");
            v[i] = int.Parse(Console.ReadLine());
        }

        ExibeVetor(v, x);
    }


    static void ExibeVetor(int[] v, int x)
    {
        Console.WriteLine($"Quantidade de números menores que {x}: {ContaMenores(v, x)}");
        Console.WriteLine($"Quantidade de números maiores que {x}: {ContaMaiores(v, x)}");
        
        int[] vetorPositivos = CriarVetorPositivos(v);
        Console.Write("Vetor de positivos: ");
        MostrarElementos(vetorPositivos);
        
        int[] vetorNegativos = CriaVetorNegativos(v);
        Console.Write("Vetor de negativos: ");
        MostrarElementos(vetorNegativos);
    }

    static void MostrarElementos(int[] V)
    {
        Console.Write("[ ");
        for (int i = 0; i < V.Length; i++)
        {
            Console.Write(V[i]);
            if (i < V.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine(" ]");
    }
}


