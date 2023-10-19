using System;
using System.Reflection.Emit;
using TPCalculatrice.Operations;

namespace TPCalculatrice
{
    public class Calculatrice
    {
        public Operation Operation { get; set; }
        public Calculatrice(Operation uneop)
        {
            Operation = uneop;
        }

        public void Executer()
        {
            Operation.Executer();
        }
    }
}
