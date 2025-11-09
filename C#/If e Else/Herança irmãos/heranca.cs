/* Uma herança em dinheiro foi dividida entre três irmãos, em partes diretamente proporcionais à idade
de cada um. Para isso, é necessário:
a) solicitar o valor da herança e as idades dos três
irmãos;
b) calcular o valor da herança que caberá a cada
irmão;
c) exibir o valor da herança que cada irmão receberá.
Como o valor da parte da herança de cada irmão
pode ser calculada? */

Console.Write("Valor da herança()");
double herança = double.Parse(Console.ReadLine());

Console.Write("Idade do irmão 1()");
int f1 = int.Parse(Console.ReadLine());
Console.Write("Idade do irmão 2()");
int f2 = int.Parse(Console.ReadLine());
Console.Write("Idade do irmão 3()");
int f3 = int.Parse(Console.ReadLine());

int somaIdades = f1 + f2 + f3;
double divisao1 = (double)f1 / somaIdades;
double divisao2 = (double)f2 / somaIdades;
double divisao3 = (double)f3 / somaIdades;
