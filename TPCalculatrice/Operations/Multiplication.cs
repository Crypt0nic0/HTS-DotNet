using System;

namespace TPCalculatrice.Operations
{
    public class Multiplication : Operation
    {
        public Multiplication(int opg, int opd) : base(opg, opd)
        {
        }

        public override void Executer()
        {
            Resultat = OperandeGauche * OperandeDroite;
        }

        public override string ToString()
        {
            return $"{OperandeGauche} x {OperandeDroite}";
        }
    }
}
