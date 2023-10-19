using System;

namespace TPCalculatrice.Operations
{
    public class Soustraction : Operation
    {
        public Soustraction(int opg, int opd) : base(opg, opd)
        {
        }

        public override void Executer()
        {
            Resultat = OperandeGauche - OperandeDroite;
        }
    }
}
