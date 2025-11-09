/*Calcule o nome, idade e número de votos de dois candidatos em uma eleição. */

string cand1, cand2;
int votação1, votação2, idade1, idade2;

Console.Write("Escreva o nome do primeiro candidato: ");
cand1 = Console.ReadLine();

Console.Write("Escreva a idade do primeiro candidato: ");
idade1 = int.Parse(Console.ReadLine());

Console.Write("Escreva o número de votos que o " + cand1 + " teve: ");
votação1 = int.Parse(Console.ReadLine());

Console.Write("Escreva o nome do segundo candidato: ");
cand2 = Console.ReadLine();

Console.Write("Escreva a idade do segundo candidato: ");
idade2 = int.Parse(Console.ReadLine());

Console.Write("Escreva o número de votos que o " + cand2 + " teve: ");
votação2 = int.Parse(Console.ReadLine());

if (idade1 == idade2)
{
    Console.WriteLine("Nova eleição deve ser realizada, pois as idades são iguais.");
}

else if (votação1 > votação2)
{
    Console.WriteLine("O candidato vencedor foi o " + cand1);
}

else if (votação2 > votação1)
{
    Console.WriteLine("O candidato vencedor foi o " + cand2);
}

/*O mais velho vence*/
else if (idade1 > idade2)
{
    Console.WriteLine("Houve um empate entre os candidatos e o " + cand1 + " com " + idade1 + " anos venceu por idade!");
}

else if (idade1 < idade2)
{
    Console.WriteLine("Houve um empate entre os candidatos e o " + cand2 + " com " + idade2 + " anos venceu por idade!");
}

Console.ReadKey();