/* Fa ̧ca um programa em C# que:
(a) leia um n ́umero inteiro n;
(b) armazene em um vetor os n primeiros n ́umeros inteiros positivos pares;
(c) armazene em um vetor os n primeiros n ́umeros inteiros positivos  ́ımpares;
(d) exiba o conte ́udo dos dois vetores
*/

//recebe numero n de usuario
Console.Write("Digite um número inteiro: ");
int n = int.Parse(Console.ReadLine());
//declara vetor para pares e impares e numero inicial de par e impar
int[] vetorP = new int[n];
int[] vetorIm = new int[n];
int numPar = 0, numImp = 1;
//coloca numeros pares em pares e impares em impares
for (int i = 0; i < n; i++)
{
    vetorP[i] = numPar;
    numPar = numPar + 2;

    vetorIm[i] = numImp;
    numImp = numImp + 2;
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Números ímpares: {vetorIm[i]}");
}


for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Números pares: {vetorP[i]}");
}
