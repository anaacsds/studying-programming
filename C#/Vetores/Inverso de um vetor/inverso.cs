/* Faça um programas em C# para:
a) gerar um vetor V2, que é o inverso de outro vetor V1:
V1[2,31,4,55] => V2[55,4,31,2]
b) gerar um vetor V3 que é a concentração de outros dois vetores V1 e V2:
V1[1,9,14,20] V2[3,21,9] V3[1,9,14,20,3,21,9]
c) gerar um vetor V3 que é a intercolação ordenada de outros dois vetores ordenados V1 e V2:
V1[9,15,33] V2[11,21,29,35]
V3[...]
*/

// Questão a
int[] V1 = { 2, 31, 4, 55 }, V2 = new int[V1.Length];

// 'j' deve ser declarado para guardar a posição do V2
int j = 0; 

for (int i = V1.Length - 1; i >= 0; i--)
{
    V2[j] = V1[i];
    j++;
}

for (j = 0; j < V2.Length; j++)
{
    Console.Write(V2[j] + " "); 
}

// Questão b

int[] V3 = new int[V1.Length + V2.Length];