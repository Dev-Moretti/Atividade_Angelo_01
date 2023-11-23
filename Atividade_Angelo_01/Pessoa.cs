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
        private int Codigo;
        public string Nome { get; protected set; }
        public string Sobrenome { get; protected set; }
        public DateTime DataNascimento { get; protected set; }
        public string CPF { get; protected set; }
        public string RG { get; protected set; }
        public string Endereco { get; protected set; }
        public int Telefone { get; protected set; }



        public Pessoa() { }


        public Pessoa(string nome,string sobrenome,DateTime dataNasc,string cpf,string rg,string endereco)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNasc;
            this.CPF = cpf;
            this.RG = rg;
            this.Endereco = endereco;
        } 
        

        public Pessoa(int codigo)
        {
            SetCodigo(codigo);
        }


        public Pessoa(string nome,DateTime dataDascimento)
        {
            this.Nome = nome;
            this.DataNascimento = dataDascimento;
        }


        private void SetCodigo(int cod)
        {
            if (cod != 0 && cod != this.Codigo)
            {
                this.Codigo = cod;
            }
        }

        public int GetCodigo() 
        { 
            return this.Codigo; 
        }



        public bool TemSobrenome()
        {
            return (!String.IsNullOrEmpty(this.Sobrenome));
        }


        public override string ToString()
        {
            return $"Nome: {this.Nome} {this.Sobrenome};";
        }


    }
}
