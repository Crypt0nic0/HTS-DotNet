using System;

namespace TPCalculatrice.Operations
{
    public class Multiplication : Operation
    {
        public Multiplication(int opg, int opd) : base(opg, opd)
        {
        }

        public void Execute()
        {
            Resultat = OperandeGauche * OperandeDroite;
        }
    }
}
