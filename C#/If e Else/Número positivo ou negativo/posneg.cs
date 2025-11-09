/* Algoritmo em C# que determina se um dado numero inteiro 
(informado pelo usu´ario) e positivo, negativo ou nulo. */

int num1;

Console.Write("Escreva um número inteiro:");
num1 = int.Parse(Console.ReadLine());

if (num1 == 0)
{
Console.Write("O número é nulo.");
}

if (num1 > 0)
{
Console.Write("O número é positivo.");
}

else 
{
    Console.Write("O número é negativo.");
}