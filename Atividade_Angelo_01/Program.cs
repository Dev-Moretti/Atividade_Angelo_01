﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Angelo_01
{
    internal class Program
    {





        static void Main(string[] args)
        {
            UtilClass util = new UtilClass();

            string nome = util.LerString("Digite seu nome: ");
            string sobrenome = util.LerString("Digite seu sobrenome: ");
            DateTime datanascimento = util.LerData("Digite a data de nascimento: ");
            string cpf = util.LerCPF("Digite o CPF: ");
            string rg = util.LerString("Digite o RG: ");
            string endereco = util.LerString("Digite o endereço: ");
            //------



            //Carregar a data de nascimento e calcular a idade

            //// pessoa[pessoas.Length + 1]();
            //armazenaPessoa.Add(davi);

            //int posicaoPessoas = 0;
            //string[] nome;
            //string sobrenome;

            //for (int i = 1; i < pessoas.Length + 1; i++)
            //{
            //    nome = pessoas[posicaoPessoas].Split(' ');

            //    sobrenome = pessoas[posicaoPessoas].Substring(nome[0].Length, pessoas[posicaoPessoas].Length - nome[0].Length);

            //    Pessoa temp = new Pessoa();

            //    temp.setNome(nome[0]);

            //    temp.setSobrenome(sobrenome);

            //    armazenaPessoa.Add(temp);

            //    posicaoPessoas++;
            //}

            //foreach (Pessoa pessoa in armazenaPessoa)
            //{
            //    Console.WriteLine(pessoa.ToString());
            //}



            Console.ReadKey();

        }
    }
}
