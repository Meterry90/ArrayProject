// See https://aka.ms/new-console-template for more information
Console.WriteLine("There are many Pokemon introduced in each Generation of pokemon.");
Console.WriteLine("Below is the list of each generation and how many new pokemon were introduced");
int[] Pokemon = { 151, 100, 135, 107, 156, 72, 88, 96, 120 };
int sum = 0;
int Gen = 0;

foreach (int Mon in Pokemon)
{
    Gen++;
    sum += Mon;
    Console.WriteLine($"Gen {Gen} = {Mon} Pokemon");
}
Console.WriteLine($"There are currently {sum} Pokemon");

Console.WriteLine("Which Generation had the fewest new pokemon?");
var Answer = Console.ReadLine();
    
do
{
    Console.WriteLine("Im sorry, that is incorrect. Try again.");
    Answer = Console.ReadLine();
}
while (Answer != "6");
Console.WriteLine("Correct! Gen 6 had the Fewest.");
string[] Types = { "Normal", "Fire", "Water", "Grass", "Electric", "Fighting", "Ghost", "Psychic", "Rock", "Ground", "Poison", "Bug", "Flying", "Dragon", "Ice", "Dark", "Steel", "Fairy" };
Console.WriteLine($" There are {Types.Length} types that a Pokemon can have they are..");

foreach (string Type in Types)
{
    Console.WriteLine(Type);
}
Console.WriteLine($"Of the {Types.Length} types, how many were introduced after Generation 1?"); 
    Answer = Console.ReadLine();

do
{
    Console.WriteLine("Im sorry, that is incorrect. Try again.");
    Answer = Console.ReadLine();
}
while (Answer != "3");
Console.WriteLine("Correct! Dark, Steel, and Fairy were added later but some older pokemon were able to gain those types in the newer generation of games.");