using System;

namespace TPCalculatrice.Operations
{
    public class Modulo : Operation
    {
        public Modulo(int opg, int opd) : base(opg, opd)
        {

        }

        public void Executer()
        {
            Resultat = OperandeGauche % OperandeDroite;
        }
    }
}
