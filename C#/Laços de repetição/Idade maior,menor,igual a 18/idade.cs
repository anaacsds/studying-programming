/* Fa ̧ca um programa em C# que:
(a) leia um n ́umero inteiro n;
(b) leia o nome e a idade de n pessoas;
(c) calcule e mostre a quantidade de pessoas e a m ́edia de idade de cada uma das categorias: (a) menor de
idade (idade abaixo de 18 anos); (b) maior de idade (idade igual ou acima de 18 anos)
*/

int idade, menorIdad=0, maiorIdad=0, n, i=0, idad18 =0, media=0;
string nome;

Console.WriteLine("Escreva um número de quantidade de pessoas: ");
n = int.Parse(Console.ReadLine());

for(i=0; i < n; i++) {
Console.Write("Nome: ");
nome = Console.ReadLine();
Console.Write("Idade: ");
idade = int.Parse(Console.ReadLine());

if (idade < 18) {
    menorIdad++;
} 
else if (idade > 18) {
    maiorIdad++;
}
else if (idade == 18){
    idad18++;
}
}

    Console.Write("Menores de idade: " + menorIdad);
    Console.Write("Maiores de idade: " + maiorIdad);
    Console.Write("Idades iguais a 18: " + idad18);

media = menorIdad + maiorIdad + idad18 / 3;
Console.Write("A média é: " + media);
