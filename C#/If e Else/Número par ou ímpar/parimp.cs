/* Slgoritmo em C# que determina se um dado numero inteiro 
(informado pelo usuario) e par ou impar. */

int num1;

Console.Write("Escreva um número inteiro:");
num1 = int.Parse(Console.ReadLine());

if (num1 % 2 == 1)

{
    Console.Write("O número é ímpar");
}

else //(num1 % 2 == 0) 
{
Console.Write("O número é par");
}

