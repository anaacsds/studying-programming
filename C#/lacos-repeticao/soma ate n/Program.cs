// Faça um programa que leia um número inteiro n e calcule a soma de todos os números de 1 até n.

int n;
int soman = 0;
int soma = 0;

Console.WriteLine($"Informe um valor para n: ");
n = int.Parse(Console.ReadLine());

for(int i = 1; i < n; i++) 
{
    soman += i;
}

Console.WriteLine($"Soma sem o {n} incluso: {soman}");

for(int i = 1; i <= n; i++) 
{
    soma += i;
}

Console.WriteLine($"Soma com o {n} incluso: {soma}");