//============== JEU NOMBRE MYSTERE ==============//

const int nbMin = 1;
const int nbMax = 10;
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
    int nb = 0;
    while (nb < nbMin || nb > nbMax)
    {
        Console.WriteLine($"Saisir un nombre entre {nbMin} et {nbMax} : ");
        try
        {
            nb = int.Parse(Console.ReadLine());
        }
        catch
        {
            nb = 0;
        }
    }

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
