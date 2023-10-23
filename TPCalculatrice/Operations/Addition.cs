using System;

namespace TPCalculatrice.Operations
{
    public class Addition : Operation
    {
        public Addition(int opg, int opd) : base(opg, opd)
        {

        }

        public override void Executer()
        {
            Resultat = OperandeGauche + OperandeDroite;
        }

        public override string ToString()
        {
            return $"{OperandeGauche} + {OperandeDroite}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }
            if (obj is Addition add)
            {
                return add.OperandeGauche == OperandeGauche && add.OperandeDroite == OperandeDroite;
            }
            else
            {
                return false;
            }
        }
    }
}
