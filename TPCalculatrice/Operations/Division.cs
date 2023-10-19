using System;

namespace TPCalculatrice.Operations
{
    public class Division : Operation
    {
        public Division(int opg, int opd) : base(opg, opd)
        {

        }

        public override void Executer()
        {
            Resultat = (OperandeDroite == 0) ? 0 : OperandeGauche / OperandeDroite;
        }
    }
}
