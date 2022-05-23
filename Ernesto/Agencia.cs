using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ernesto.Ernesto
{
    internal class Agencia
    {
        public String NomeAgencia;
        public int NumdaAgencia;

        public Agencia(String NomeAgencia, int NumdaAgencia) /*Metodo Construtor*/
        {
            this.NomeAgencia = NomeAgencia;
            this.NumdaAgencia = NumdaAgencia;
        }

        public int getNumdaAgencia()
        {
            return NumdaAgencia;
        }

        public void SetNumdaAgencia(int n)
        {
            n =  NumdaAgencia ;
        }

        public string getNomeAgencia()
        {
            return NomeAgencia;
        }

        public void SetNomedaAgencia(string a)
        {
            a = NomeAgencia;
        }
    }
}
