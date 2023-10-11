using TPCalculatrice;

Console.WriteLine("Salut et bienvenu dans le TP Calculatrice");

Calculatrice Calc = new Calculatrice();

Console.WriteLine("Saisir NB1 : ");
Calc.OperandeGauche = int.Parse(Console.ReadLine());
Console.WriteLine("Saisir NB2 : ");
Calc.OperandeDroite = int.Parse(Console.ReadLine());
Console.WriteLine("Saisir un opérateur entre + - * / %");
string op = Console.ReadLine();

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