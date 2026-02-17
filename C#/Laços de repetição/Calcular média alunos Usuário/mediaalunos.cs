int idade, n = 1, soma = 0, i;
double media;

    Console.Write("Escreva a quantidade de alunos que será feita a média: ");
    n = int.Parse(Console.ReadLine());

// valor inicial, quando parar e passo a passo
for (i=1; i <= n; i++)
{
    Console.Write("Escreva a idade dos " + n + " alunos: ");
    idade = int.Parse (Console.ReadLine());
    soma = soma + idade;
}
    media = soma / n;
    Console.WriteLine("A média de idade de toda a sala é " + (media) + "!");