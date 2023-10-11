using System;

namespace TPCalculatrice.Operations
{
    public class Operation
    {
        public int OperandeGauche { get; set; }
        public int OperandeDroite { get; set; }

        public int Resultat { get; set; }

        public Operation(int opg, int opd)
        {
            OperandeGauche = opg;
            OperandeDroite = opd;
        }
    }
}
