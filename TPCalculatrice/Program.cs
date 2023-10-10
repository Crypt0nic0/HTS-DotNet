using TPCalculatrice;

Console.WriteLine("Salut et bienvenu dans le TP Calculatrice");

Calculatrice Calc = new Calculatrice();

int res = 0;

Console.WriteLine("Saisir NB1 : ");
int nb1 = int.Parse(Console.ReadLine());
Console.WriteLine("Saisir NB2 : ");
int nb2 = int.Parse(Console.ReadLine());
Console.WriteLine("Saisir un opérateur entre + - * / %");
string op = Console.ReadLine();

switch (op)
{
    case "+":
        res = Calc.Addition(nb1, nb2);
        break;
    case "-":
        res = Calc.Soustraction(nb1, nb2);
        break;
    case "*":
        res = Calc.Multiplication(nb1, nb2);
        break;
    case "/":
        res = Calc.Division(nb1, nb2);
        break;
    case "%":
        res = Calc.Modulo(nb1, nb2);
        break;
    default:
        break;
}

Console.WriteLine($"Résultat de l'opération {nb1} {op} {nb2} = {res}");