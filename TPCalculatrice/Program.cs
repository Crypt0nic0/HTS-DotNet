﻿using TPCalculatrice;
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

try
{
    Console.WriteLine("Saisir un opérateur entre + - * / %");
    string? op = Console.ReadLine();
    if (op is null)
    {
        Console.WriteLine("Aucun opérateur saisi");
    }
    else
    {
        Operation operation = op switch
        {
            "+" => new Addition(nb1, nb2),
            "-" => new Soustraction(nb1, nb2),
            "*" => new Multiplication(nb1, nb2),
            "/" => new Division(nb1, nb2),
            "%" => new Modulo(nb1, nb2),
            _ => throw new OperateurNonReconnuException(op)
        };

        Calculatrice Calc = new Calculatrice(operation);
        Calc.Executer();
        Console.WriteLine($"Résultat de l'opération {Calc.Operation.ToString()} = {Calc.Operation.Resultat}");
    }
}
catch (OperateurNonReconnuException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine($"Erreur générale : {e.Message}");
}