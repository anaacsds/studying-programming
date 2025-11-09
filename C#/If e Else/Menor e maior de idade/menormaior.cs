/*Algortimo que lê sua idade*/

int idade;

Console.Write("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade <= 17)
{
    Console.WriteLine("Você tem menos que 17 anos, logo é menor de idade.");
}

else if (idade >= 65)
{
    Console.WriteLine("Você tem mais que 65 anos.");
}

/* Outro if possivel: if(idade >= 18 && <= 64) */

else
{
    Console.WriteLine("Você tem entre 18 a 64 anos.");
}

Console.ReadKey(); 

