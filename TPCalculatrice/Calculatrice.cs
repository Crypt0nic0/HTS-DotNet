using System;

namespace TPCalculatrice
{
    public class Calculatrice
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Soustraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            int resultat = (b == 0) ? 0 : a / b;
            return resultat;
        }

        public int Modulo(int a, int b)
        {
            return a % b;
        }
    }
}
