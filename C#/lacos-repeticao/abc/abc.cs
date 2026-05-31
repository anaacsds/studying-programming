/* 
Fa ̧ca um algoritmo em C# que leia trˆes n ́umeros inteiros positivos a, b e c. O algoritmo deve:
(a) mostrar quantos n ́umeros m ́ultiplos de c existem entre a e b (inclusive), caso a < b;
(b) mostrar a seguinte mensagem: “Os valores de a e b n ̃ao permitem realizar a tarefa.”, caso a ≥ b.
*/

int a, b, c, contMultiplos = 0;

Console.WriteLine("Digite o valor de 'a': ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de 'b': ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de 'c': ");
c = int.Parse(Console.ReadLine());

if( a < b ) {
for (int i = a; i <= b; i ++)
{
    if (i % 2 == 0 )
    contMultiplos++;
}
}
else
{
    Console.WriteLine($"Os valores de {a} e {b} n ao permitem realizar a tarefa.");
}

Console.WriteLine(contMultiplos);