using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Angelo_01
{
    internal class Empresa : Pessoa
    {
        public string CNPJ {  get; private set; }

        public Empresa(string nome, string cnpj, string endereco, int telefone) 
        {
            Nome = nome;
            this.CNPJ = cnpj;
            Endereco = endereco;
            Telefone = telefone;
        }




    }
}
