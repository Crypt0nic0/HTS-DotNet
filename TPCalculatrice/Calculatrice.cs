using System;

namespace TPCalculatrice
{
    public class Calculatrice
    {
        public int OperandeGauche { get; set; }
        public int OperandeDroite { get; set; }
        public int Resultat { get; set; }

        public void Addition()
        {
            Resultat = OperandeGauche + OperandeDroite;
        }

        public void Soustraction()
        {
            Resultat = OperandeGauche - OperandeDroite;
        }

        public void Multiplication()
        {
            Resultat = OperandeGauche * OperandeDroite;
        }

        public void Division()
        {
            Resultat = (OperandeDroite == 0) ? 0 : OperandeGauche / OperandeDroite;
        }

        public void Modulo()
        {
            Resultat = OperandeGauche % OperandeDroite;
        }
    }
}
