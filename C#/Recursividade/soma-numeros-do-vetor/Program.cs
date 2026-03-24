/* Faça uma função recursiva capaz de imprimir em tela a soma dos elementos de um vetor de 20 posições
composto de números aleatórios.
*/

class Program {
    static void Main(string[]args) {

        int result;
        int i = 0;
        int [] v = new int[20];

        PreenchV(v, i);
        result = SomaVAleat(v, i);

        Console.WriteLine(result);
    }

    static int[] PreenchV(int[]v, int i) {
        Random x = new Random();
        //Preenchendo vetor
        if(i < v.Length) {
            v[i] = x.Next(1,50);

            return PreenchV(v, i + 1);
        }
        return v;
    }

    static int SomaVAleat(int[]v, int i) {

        int soma = 0;

        if(i < v.Length) 
        soma = v[i] + SomaVAleat(v, i + 1);
        
        return soma;
        }
    }
