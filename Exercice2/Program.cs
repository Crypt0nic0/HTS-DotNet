// See https://aka.ms/new-console-template for more information
Console.WriteLine("Saisir votre prénom : ");
string prenom = Console.ReadLine();
Console.WriteLine("Saisir votre âge : ");
string age = Console.ReadLine();
Console.WriteLine($"Prénom de l'utilisateur : {prenom} - Age de l'utilisateur : {age} ans");
Console.WriteLine("Bonjour " + prenom + ", vous avez " + age + " ans.");