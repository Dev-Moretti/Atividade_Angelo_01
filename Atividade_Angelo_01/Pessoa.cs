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
        public int Codigo { get; protected set; }
        public string Nome { get; protected set; }
        public string Sobrenome { get; protected set; }
        public DateTime DataNascimento { get; protected set; }
        public int Idade { get; protected set; }
        public string CPF { get; protected set; }
        public string RG { get; protected set; }
        public string Endereco { get; protected set; }
        public string Telefone { get; protected set; }

         

        public Pessoa() { }


        public Pessoa(int codigo, string nome,string sobrenome,DateTime dataNasc,int idade, string cpf,string rg,string endereco,string telefone)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNasc;
            this.Idade = idade;
            this.CPF = cpf;
            this.RG = rg;
            this.Endereco = endereco;
            this.Telefone = telefone;
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
