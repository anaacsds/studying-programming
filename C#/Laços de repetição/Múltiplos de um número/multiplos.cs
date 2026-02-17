/* Algoritmo em C# que lê três n ́umeros inteiros positivos a, b e c. 
(a) mostra quantos n umeros m ultiplos de c existem entre a e b (inclusive), caso a < b;
(b) mostra a seguinte mensagem: “Os valores de a e b n ̃ao permitem realizar a tarefa.”, caso a ≥ b.
*/

int a, b, c, multiplosC=0;

Console.Write("Defina o valor de: ");
Console.WriteLine("a: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("b: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("c: ");
c = int.Parse(Console.ReadLine());

if(a < b){
for (int i=a; i <= b; i++ ){
    if (i % 2 == 0) {
    multiplosC ++;
}
}
    }

else if (a>b){
    Console.WriteLine("Os valores de " + a + " e " + b + " não permitem realizar a tarefa!");
}

    
Console.WriteLine(multiplosC);