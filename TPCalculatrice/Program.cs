using TPCalculatrice;
using TPCalculatrice.Operations;

Console.WriteLine("Salut et bienvenu dans le TP Calculatrice");


Console.WriteLine("Saisir l'opérande gauche : ");
int nb1 = int.Parse(Console.ReadLine());
Console.WriteLine("Saisir l'opérande droite : ");
int nb2 = int.Parse(Console.ReadLine());
Console.WriteLine("Saisir un opérateur entre + - * / %");
string op = Console.ReadLine();

Operation operation;

switch (op)
{
    case "+":
        operation = new Addition(nb1, nb2);
        break;
    case "-":
        operation = new Soustraction(nb1, nb2);
        break;
    case "*":
        operation = new Multiplication(nb1, nb2);
        break;
    case "/":
        operation = new Division(nb1, nb2);
        break;
    case "%":
        operation = new Modulo(nb1, nb2);
        break;
    default:
        operation = new Addition(nb1, nb2);
        break;
}

Calculatrice Calc = new Calculatrice(operation);
Calc.Executer();

Console.WriteLine($"Résultat de l'opération {nb1} {op} {nb2} = {Calc.Operation.Resultat}");