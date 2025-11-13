
double [] v1a, v2b;
string [] vetor;
int m;

Console.Write("Informe o valor dos três vetores: ");
m = int.Parse(Console.ReadLine());
v1a = new double [m];
v2b = new double [m];
vetor = new string [m];

for (int i = 0; i < v1a.Length; i ++)
{
    Console.WriteLine($"Valor do {i + 1} número do vetor: ");
    v1a[i] = double.Parse(Console.ReadLine());
}

for (int i = 0; i < v1a.Length; i ++)
{
    Console.WriteLine($"Valor do {i + 1} número do vetor: ");
    v2b[i] = double.Parse(Console.ReadLine());
}

for (int i = 0; i < m; i++) 
{
    if (v1a[i] > v2b[i])
    {
        vetor[i] = "Maior"; 
    }
    else if (v1a[i] < v2b[i])
    {
        vetor[i] = "Menor";
    }
    else
    {
        vetor[i] = "Igual";
    }
}

for (int i = 0; i < m; i++)
{
    Console.WriteLine($" Resultado: Posição {i}: {v1a[i]} é {vetor[i]} que {v2b[i]}");
}