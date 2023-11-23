using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Angelo_01
{
    internal class Pessoa
    {
        private int codigo;
        public string nome { get; private set; }
        public string sobrenome { get; private set; }
        public DateTime dataNascimento { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public string endereco { get; private set; }


        List<Pessoa> pessoasList = new List<Pessoa>();

        public Pessoa() { }


        public Pessoa(string nome,string sobrenome,DateTime dataNasc,string cpf,string rg,string endereco)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.dataNascimento = dataNasc;
            this.CPF = cpf;
            this.RG = rg;
            this.endereco = endereco;
        } 
        

        public Pessoa(int codigo)
        {
            setCodigo(codigo);
        }


        public Pessoa(string nome,DateTime dataDascimento)
        {
            this.nome = nome;
            this.dataNascimento = dataDascimento;
        }


        private void setCodigo(int cod)
        {
            if (cod != 0 && cod != this.codigo)
            {
                this.codigo = cod;
            }
        }

        public int getCodigo() 
        { 
            return this.codigo; 
        }

        public bool TemSobrenome()
        {
            return (!String.IsNullOrEmpty(this.sobrenome));
        }


        public override string ToString()
        {
            return $"Nome: {this.nome} {this.sobrenome};";
        }


    }
}
