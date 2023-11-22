using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Angelo_01
{
    internal class Pessoa
    {
        private int codigo { get; set; }
        private string nome { get; set; }
        private string sobrenome { get; set; }
        private DateTime dataDascimento { get; set; }
        private string CPF { get; set; }
        private string RG { get; set; }
        private string endereco { get; set; }

        public Pessoa()
        {

        }

        List<Pessoa> pessoaList;

        public Pessoa(int codigo)
        {
            this.codigo = codigo;
        }


        public Pessoa(string nome)
        {
            this.nome = nome;
        }


        public Pessoa(string nome, DateTime dataDascimento)
        {
            this.nome = nome;
            this.dataDascimento = dataDascimento;
        }


        public Pessoa(string[] strings)
        {

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


        public int CalculaIdade()
        {
            int idade = 0;
            return idade;
            //Calcular a idade da pessoa em anos
        }





        public override string ToString()
        {
            return $"Nome: {this.nome} {this.sobrenome};";
        }


    }
}
