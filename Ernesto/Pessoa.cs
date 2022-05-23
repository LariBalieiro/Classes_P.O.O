using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ernesto.Ernesto
{
    internal class Pessoa
    {
        string nome;
        int id;
        double cpf;
        string end;

        public Pessoa(string nome) /*Metodo Construtor*/
        {
            this.nome = nome;
            
        }
        public void setNome(string Nome)
        {
            nome = Nome;
        }
        public String getNome()
        {
            return nome;
        }

        public void Soma_id()
        {
            id = id + 10;
        }
        public String Valido_cpf()
        {
            if (cpf != 0)
            {
                return "valido";
            }
            else
            {
                return "invalido";
            }
        }
       
    }

}

