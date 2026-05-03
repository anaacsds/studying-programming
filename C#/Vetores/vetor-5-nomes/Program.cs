/* Faça:
Um vetor de 5 nomes
Leia os nomes
Mostre todos*/

string []v = new string [5];

for(int i = 0; i < v.Length; i++)
{
    Console.WriteLine($"Nome {i+1}: ");
    v[i] = Console.ReadLine();
}

Console.Clear();

for(int i = 0; i < v.Length; i ++)
{
    Console.Write($"{v[i]} - ");
}