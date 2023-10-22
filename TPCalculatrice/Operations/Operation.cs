using System;

namespace TPCalculatrice.Operations
{
    public abstract class Operation
    {
        protected int OperandeGauche { get; }
        protected int OperandeDroite { get; }

        public int Resultat { get; protected set; }

        public Operation(int opg, int opd)
        {
            OperandeGauche = opg;
            OperandeDroite = opd;
        }

        public abstract void Executer();
    }
}
