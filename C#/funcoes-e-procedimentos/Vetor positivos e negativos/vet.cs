/*
8. Fa ̧ca um programa em C# (incluindo o procedimento principal Main) que:
(a) defina um vetor de n ́umeros inteiros V j ́a iniciado com os valores: −57, −66, 76, 97, −23,
49 e 26;
(b) copie para um vetor VP os n ́umeros positivos presentes em V e para outro vetor VN os
n ́umeros negativos presentes em V ;
(c) exiba cada um dos vetores V , VP e VN 
*/

class Program
{

    static void [] MostraElementos (int [] v)
    {
        Console.Write("[ ");
        for (int i = 0; i < v.Length; i++)
        {
            Console.Write(v[i]);
            Console.Write(", ");
        }
        Console.WriteLine(" ]");
    }

    static int [] Vp (int []v)
    {
        int [] Vp;
        int i, pos = 0, cont = 0;

        for( i =0 ; i< v.Length; i++)
        {
            if (v[i] > 0)
            cont++;
        }

        Vp = new int [cont];

        for(i = 0; i < v.Length; i++)
        {
            if(v[i] > 0)
            {
                Vp[pos] = v[i];
                pos ++;
            }
        }
        return Vp;
    }

    static int [] Vn (int []v)
    {
        int [] Vn;
        int i, pos = 0, cont = 0;

        for( i =0 ; i< v.Length; i++)
        {
            if (v[i] < 0)
            cont++;
        }

        Vn = new int [cont];

        for(i = 0; i < v.Length; i++)
        {
            if(v[i] < 0)
            {
                Vn[pos] = v[i];
                pos ++;
            }
        }
        return Vn;
    }


    static void Main(string[]args)
    {
    int [] v = {-57, -66, 76, 97, -23, 49, 26};  

        Console.Write("Vetor V: ");
        MostraElementos(v);

        Console.Write("Vetor VP: ");
        MostraElementos(vp);

        Console.Write("Vetor VN: ");
        MostraElementos(vn);

    }
}