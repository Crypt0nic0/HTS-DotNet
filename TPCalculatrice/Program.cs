using TPCalculatrice;

Console.WriteLine("Salut et bienvenu dans le TP Calculatrice");


Console.WriteLine("Saisir l'opérande gauche : ");
int nb1 = int.Parse(Console.ReadLine());
Console.WriteLine("Saisir l'opérande droite : ");
int nb2 = int.Parse(Console.ReadLine());
Console.WriteLine("Saisir un opérateur entre + - * / %");
string op = Console.ReadLine();

Calculatrice Calc = new Calculatrice(nb1, nb2);

switch (op)
{
    case "+":
        Calc.Addition();
        break;
    case "-":
        Calc.Soustraction();
        break;
    case "*":
        Calc.Multiplication();
        break;
    case "/":
        Calc.Division();
        break;
    case "%":
        Calc.Modulo();
        break;
    default:
        break;
}

Console.WriteLine($"Résultat de l'opération {Calc.OperandeGauche} {op} {Calc.OperandeDroite} = {Calc.Resultat}");