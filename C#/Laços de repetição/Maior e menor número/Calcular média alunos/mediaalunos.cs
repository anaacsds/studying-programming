int idade,soma = 0, i;
double media;

// primeiro i é o valor inicial, o segundo é a hora de parar e o terceiro é o passo a passo (tipo adicionar mais um)

/*
for (i=1; i<=10; i++)
{
    Console.Write("Informe sua idade: ");
    idade = int.Parse (Console.ReadLine());
    soma = soma + idade;
}
    media = soma/10;
    Console.WriteLine("A média é " + (media));
*/

//para ficar mais organizado:
for (i=1; i<=10; i++)
{
    Console.Write($"Informe a idade {i} /10: ");
    idade = int.Parse (Console.ReadLine());
    soma = soma + idade;
}
    media = soma/10;
    Console.WriteLine("A média é " + (media));

