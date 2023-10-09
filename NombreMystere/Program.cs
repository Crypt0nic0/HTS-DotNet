//============== JEU NOMBRE MYSTERE ==============//

const int nbmyst = 5;

Console.WriteLine("Bonjour et bienvenu dans le jeu du Nombre Mystère, quel est votre nom ?");
string nom = Console.ReadLine();

Console.WriteLine($"Bienvenu {nom}");
Console.WriteLine("Saisir un nombre : ");
int nb = int.Parse(Console.ReadLine());

if (nb == nbmyst)
{
    Console.WriteLine("Bravo vous avez trouvé !");
}
else if (nb > nbmyst)
{
    Console.WriteLine("Perdu, vous êtes trop haut =(");
}
else
{
    Console.WriteLine("Perdu, vous êtes trop bas =(");
}
