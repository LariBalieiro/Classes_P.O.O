using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ernesto.Ernesto
{
    internal class Conta
    {
        public String Nome;
        public int Num; 
        public Double Limite;
        public Double Saldo;

        public  Conta(Double Saldo) /*Metodo Construtor*/
        {    
            this.Saldo = Saldo;
        }

        public void Deposito(Double Valor)
        {
            Saldo = Saldo + Valor;
        }

        public void Saque(Double Valor)
        {
            Saldo = Saldo - Valor;

        }
    }

}

