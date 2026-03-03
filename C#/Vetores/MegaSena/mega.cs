/*Elabore um programa que permita ao usuário informar a quantidade de dezenas apostadas em 
um jogo. Em seguida, o programa deve ler as dezenas apostadas e armazená-las em um vetor.

Depois, o programa deve solicitar ao usuário que informe 6 dezenas sorteadas, 
armazenando-as em outro vetor. Ao final, o programa deve:

Exibir todas as dezenas apostadas;
Exibir todas as dezenas sorteadas;
Comparar as dezenas apostadas com as sorteadas;
Contar e exibir a quantidade total de acertos (quantas dezenas apostadas coincidem com as sorteadas).
*/

int [] dezAp, dezSor = new int [6];
int n,i, j, cont=0;

Console.Write("Informe a quantidade de números apostados: ");
n = int.Parse(Console.ReadLine());
dezAp = new int[n];

for(i=0;i < dezAp.Length; i ++)
{
    Console.WriteLine($"Digite a {i +1} dezena: ");
    dezAp[i] = int.Parse(Console.ReadLine());
}

for(i=0; i < dezSor.Length; i++)
{
    Console.WriteLine($"Digite a {i+1} dezena sorteada: ");
    dezSor[i] = int.Parse(Console.ReadLine());
}

for(i=0;i < dezAp.Length; i ++)
{
    Console.WriteLine($"Dezenas apostadas: {dezAp[i]}");
}

for(i=0; i < dezSor.Length; i++)
{
    Console.WriteLine($"Dezenas sorteadas: {dezSor[i]}");
}

for(i=0; i< dezAp.Length; i++)
{
    for(j=0; j <dezSor.Length; j ++)
    {
        if (dezAp[i] == dezSor[j])
        {
            cont++;
        }
    }
}

    Console.WriteLine($"Número de acertos: {cont}");
