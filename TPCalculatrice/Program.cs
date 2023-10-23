using TPCalculatrice;
using TPCalculatrice.Operations;

int GetIntValue(string valeur)
{
    int? resultat = null;
    while (resultat is null)
    {
        Console.WriteLine($"Saisissez la valeur {valeur} entière");
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


int nb1 = GetIntValue("première");
int nb2 = GetIntValue("deuxième");
Console.WriteLine("Saisir un opérateur entre + - * / %");
string? op = Console.ReadLine();

Operation operation;

switch (op)
{
    case "+":
        operation = new Addition(nb1, nb2);
        Addition a2 = new Addition(nb1, nb2);
        Console.WriteLine($"Additions égales ? {operation.Equals(a2)}");
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

Console.WriteLine($"Résultat de l'opération {Calc.Operation.ToString()} = {Calc.Operation.Resultat}");