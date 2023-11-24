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


        public Pessoa(int codigo, string nome, string sobrenome, DateTime dataNasc, int idade, string cpf, string rg, string endereco, string telefone)
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
        

        public bool TemSobrenome()
        {
            return (!String.IsNullOrEmpty(this.Sobrenome));
        }

        public override string ToString()
        {
            return $"\n____________________________" +
                   $"\n Codigo: {this.Codigo}"+
                   $"\n Nome: {this.Nome} {this.Sobrenome}" +
                   $"\n Idade: {this.Idade} ano(s)" +
                   $"\n CPF: {this.CPF}" +
                   $"\n Telefone: {this.Telefone}" +
                   $"\n Endereço: {this.Endereco}" +
                   $"\n____________________________";
        }

    }
}