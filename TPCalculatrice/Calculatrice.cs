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
            if (Operation is Addition a)
            {
                a.Executer();
            }
            else if (Operation is Soustraction s)
            {
                s.Executer();
            }
            else if (Operation is Multiplication mu)
            {
                mu.Executer();
            }
            else if (Operation is Division d)
            {
                d.Executer();
            }
            else if (Operation is Modulo mo)
            {
                mo.Executer();
            }
            else
            {
                Console.WriteLine("Opération non reconnue");
            }

        }
    }
}
