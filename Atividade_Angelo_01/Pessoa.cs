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


        private int codigo { get; set; }
        private string nome { get; set; }
        private string sobrenome { get; set; }
        private DateTime dataNascimento { get; set; }
        private string CPF { get; set; }
        private string RG { get; set; }
        private string endereco { get; set; }


        List<Pessoa> pessoasList = new List<Pessoa>();


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
            this.codigo = codigo;
        }


        public Pessoa() { }


        public Pessoa(string nome,DateTime dataDascimento)
        {
            this.nome = nome;
            this.dataNascimento = dataDascimento;
        }


        public void setNome(string v)
        {
            this.nome = v;
        }


        public void setCPF(string v)
        {
            this.CPF = v;
        }


        public string getSobrenome()
        {
            return this.sobrenome;
        }


        public void setSobrenome(string v)
        {
            this.sobrenome = v;
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
