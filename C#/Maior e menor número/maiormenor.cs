//# Código em C# para identificar o maior e o menor número a partir de um valor fornecido pelo usuário.

int n1, n2; // Declarando as variaveis dos números que serão informados
Console.WriteLine("Defina dois números para descobrir qual é o maior e qual é o menor valor dentre eles: ");
Console.Write("Primeiro número: "); // Mensagem que aparece para o usuário
n1 = int.Parse(Console.ReadLine()); // Usuário escreve o número e o programa converte para número inteiro
Console.Write("Segundo número: ");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2) // Confere se o número "n1" é maior que o número "n2"
{
    Console.WriteLine("Maior:" + n1);
    Console.WriteLine("Menor: " + n2);
}
else if (n2 > n1)  // Confere se o número "n2 é maior que o número "n1"
{
    Console.WriteLine("Maior:" + n2);
    Console.WriteLine("Menor: " + n1);
}
else if (n2 == n1)  // Confere se os números "n1" e "n2" são iguais
{
    Console.WriteLine(n1 + " e " + n2 + " são iguais!");
}