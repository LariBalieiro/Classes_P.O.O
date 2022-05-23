using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ernesto.Ernesto
{

    internal class Program
    {
        static void Main(string[] args)/* Instanciando Objeto */
        {
            Pessoa P1 = new Pessoa("Marcos"); 
            Console.Write(P1.getNome());
            P1.setNome("joao");
            Console.Write(P1.getNome());
            P1.setNome("Maria");
            Console.Write(P1.getNome());


            Conta C = new Conta(0);
            C.Saque(10);

            Endereco ED = new  Endereco("Vila Boa Vista","Rua josevedo",1209,2344567);

            Agencia A = new Agencia("Br@d&sc0", 0000);
           
        }
    }
}
