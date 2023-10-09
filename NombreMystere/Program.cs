//============== JEU NOMBRE MYSTERE ==============//

const int nbmyst = 5;
bool trouv = false;
string indic = "";

List<int> histoNb = new List<int>();

Console.WriteLine("Bonjour et bienvenu dans le jeu du Nombre Mystère, quel est votre nom ?");
string nom = Console.ReadLine();

Console.WriteLine($"Bienvenu {nom}");

while (!trouv)
{
    Console.Clear();
    Console.WriteLine(indic);
    Console.WriteLine("Liste de nombres déjà joués : ");
    foreach (int n in histoNb)
    {
        Console.Write($" {n}");
    }
    Console.WriteLine("");
    Console.WriteLine("Saisir un nombre : ");
    int nb = int.Parse(Console.ReadLine());
    histoNb.Add(nb);

    if (nb == nbmyst)
    {
        Console.WriteLine("Bravo vous avez trouvé !");
        trouv = true;
    }
    else if (nb > nbmyst)
    {
        indic = "Perdu, vous êtes trop haut =(";
    }
    else
    {
        indic = "Perdu, vous êtes trop bas =(";
    }
}
