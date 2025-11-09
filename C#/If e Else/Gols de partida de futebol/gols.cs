/* Algoritmo em C# que:
(a) lei o nome e o numero de gols marcados por duas equipes em uma partida de futebol;
(b) determina qual foi a equipe que venceu a partida ou se houve empate. */

string equip1, equip2;
int gol1, gol2;

Console.Write("Qual o nome do primeiro time?");
equip1 = Console.ReadLine();
Console.Write("Qual o número de gols do time?");
gol1 = int.Parse (Console.ReadLine ());

Console.Write("Qual o nome do segundo time?");
equip2 = Console.ReadLine ();
Console.Write("Qual o número de gols do time?");
gol2 = int.Parse (Console.ReadLine ());

if (gol1 > gol2)
{
    Console.Write("A equipe " + equip1 + " venceu!");
}

else if (gol1 < gol2)
{
    Console.Write("A equipe " + equip2 + " venceu!");
}

else
{
    Console.Write("As equipes empataram.");
}

