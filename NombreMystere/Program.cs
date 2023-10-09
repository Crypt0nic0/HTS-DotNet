//============== JEU NOMBRE MYSTERE ==============//

const int nbmyst = 5;
bool trouv = false;

Console.WriteLine("Bonjour et bienvenu dans le jeu du Nombre Mystère, quel est votre nom ?");
string nom = Console.ReadLine();

Console.WriteLine($"Bienvenu {nom}");

while (!trouv)
{
    Console.WriteLine("Saisir un nombre : ");
    int nb = int.Parse(Console.ReadLine());

    if (nb == nbmyst)
    {
        Console.WriteLine("Bravo vous avez trouvé !");
        trouv = true;
    }
    else if (nb > nbmyst)
    {
        Console.WriteLine("Perdu, vous êtes trop haut =(");
    }
    else
    {
        Console.WriteLine("Perdu, vous êtes trop bas =(");
    }
}
