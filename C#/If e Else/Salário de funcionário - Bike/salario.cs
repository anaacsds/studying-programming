/* Uma loja vende bicicletas com um acréscimo de 50% sobre o seu preço de custo. Ela paga a cada vendedor 2 salários
mínimos mensais, mais uma comissão de 15% sobre o preço de custo de cada bicicleta vendida, dividida igualmente entre
eles. Para isso, é necessário solicitar:
a) o número de empregados da loja;
b) o valor do salário mínimo;
c) o preço de custo de cada bicicleta;
d) o número de bicicletas vendidas.
Em seguida deve-se calcular e exibir:
a) o salário final de cada empregado;
b) o lucro (líquido) da loja.
Quais os cálculos necessários que devem ser feitos?*/

Console.Write("Digite o número de empregados: ");
int numFuncionários = int.Parse(Console.ReadLine());

Console.Write("Digite o número de bicicletas vendidas:");
int numBici = int.Parse(Console.ReadLine());

Console.Write("Digite o valor do salário mínimo dos funcionários:");
int numSalMínimo = int.Parse(Console.ReadLine());

Console.Write("Digite o preço de custo de cada biclicleta:");
double valorBici = double.Parse(Console.ReadLine());

double percentualLucro = 0.50;
// 50% sobre o custo
double precoVenda = valorBici * (1 + percentualLucro);

double salarioFixo = 2 * numSalMínimo;
