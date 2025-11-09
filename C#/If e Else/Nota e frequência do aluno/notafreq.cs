/* Algoritmo em C# para ler a nota e a frequencia de um aluno no semestre. O algoritmo deve 
escrever a nota, a frequencia e a seguinte mensagem:
(a) “PARABENS! Voce foi aprovado”: somente se o aluno obteve media com valor 
igual ou superior a 60  pontos e frequˆencia com valor igual ou superior a 75%;
(b) “Voce foi REPROVADO! Estude mais”: somente se o aluno obteve media com 
valor inferior a 60 pontos ou frequˆencia com valor inferior a 75%.
*/

double nota, freq;

Console.Write("Qual foi sua nota obtida?");
nota = double.Parse(Console.ReadLine());

Console.Write("Qual foi sua frequência nas aulas?");
freq = double.Parse(Console.ReadLine());

if ((nota >= 60) & (freq >= 75))
{
    Console.WriteLine("Parabéns! Você passou");
}

else
{
    Console.WriteLine("Você reprovou...");
}