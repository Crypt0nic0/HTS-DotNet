using TPCalculatrice;
using TPCalculatrice.Operations;

int GetIntValue(int nb)
{
    int? resultat = null;
    while (resultat is null)
    {
        Console.WriteLine($"Saisissez la valeur {nb} entière");
        String? saisie = Console.ReadLine();
        if (saisie is not null)
        {
            try
            {
                resultat = int.Parse(saisie);
            }
            catch
            {
                resultat = null;
            }
        }
    }
    return resultat.Value;
}

Console.WriteLine("Salut et bienvenu dans le TP Calculatrice");


int nb1 = GetIntValue(1);
int nb2 = GetIntValue(2);
Console.WriteLine("Saisir un opérateur entre + - * / %");
string? op = Console.ReadLine();

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