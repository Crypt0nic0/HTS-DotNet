int[] tabNb = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Saisir un nombre : ");
    tabNb[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Ligne {i} : {tabNb[i]}");
}