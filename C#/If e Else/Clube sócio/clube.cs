/* Em um determinado clube os s ocios podem ser de dois tipos: fundador e contribuinte. 
Havera um aumento nas mensalidades de 10% para o śocio fundador e 17% para o s ́ocio contribuinte.
(a) le o tipo (1 para fundador e 2 para contribuinte) e o valor da mensalidade de um determinado s ocio;
(b) calcula o valor do aumento e da nova mensalidade;
(c) escreve o tipo, o valor atual da mensalidade, o valor do aumento e o valor da nova mensalidade.
*/

double mensalidade;
int n;

Console.WriteLine("Digite sua opção desejada: 1 para fundador e 2 para contribuinte: ");
n = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da sua mensalidade: ");
mensalidade = double.Parse(Console.ReadLine());

if (n == 1) {
    Console.WriteLine ("A sua mensalidade será de " + mensalidade * 1.10 + "!");
}

else if (n == 2) {
    Console.WriteLine ("A sua mensalidade será de " + mensalidade * 1.17 + "!");
}