using System;

namespace TPCalculatrice.Operations
{
    public class Modulo : Operation
    {
        public Modulo(int opg, int opd) : base(opg, opd)
        {

        }

        public override void Executer()
        {
            Resultat = OperandeGauche % OperandeDroite;
        }

        public override string ToString()
        {
            return $"{OperandeGauche} % {OperandeDroite}";
        }
    }
}
