// See https://aka.ms/new-console-template for more information

// VERSION 1
/*
Console.WriteLine("Saisir votre prénom : ");
string prenom = Console.ReadLine();
Console.WriteLine("Saisir votre âge : ");
string age = Console.ReadLine();
Console.WriteLine($"Prénom de l'utilisateur : {prenom} - Age de l'utilisateur : {age} ans");
Console.WriteLine("Bonjour " + prenom + ", vous avez " + age + " ans.");
*/

// VERSION 2
const int maj = 18;
Console.WriteLine("Saisir votre prénom : ");
string prenom = Console.ReadLine();
Console.WriteLine("Saisir votre âge : ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"Bonjour {prenom}, vous avez {age} ans.");
if (age >= maj)
{
    Console.WriteLine("Vous êtes majeur.");
}
else
{
    Console.WriteLine("Vous êtes mineur.");
}