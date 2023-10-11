using System;

namespace TPCalculatrice.Operations
{
    public class Addition : Operation
    {
        public Addition(int opg, int opd) : base(opg, opd)
        {

        }

        public void Executer()
        {
            Resultat = OperandeGauche + OperandeDroite;
        }
    }
}
