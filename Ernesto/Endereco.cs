using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ernesto.Ernesto
{
    internal class Endereco
    {
        public String bairro;
        public String nomeRua;
        public int numeroRua;
        public int CEP;

        public Endereco(String bairro, String nomeRua, int numeroRua, int CEP)/*Metodo Construtor*/
        {
            this.bairro = bairro;
            this.nomeRua = nomeRua;
            this.numeroRua = numeroRua;
            this.CEP = CEP;
        }

        public int getCEP()
        {
            return this.CEP;
        }

        public void setCEP(int CEP)
        {
            CEP = this.CEP;
        }

    }
}
