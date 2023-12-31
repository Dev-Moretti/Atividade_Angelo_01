﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Atividade_Angelo_01
{
    internal class UtilClass
    {
        public UtilClass() { }

        public string LerString(string pergunta)
        {
            string leitura;

            while (true)
            {
                Console.Write(pergunta);
                leitura = Console.ReadLine();

                if (!string.IsNullOrEmpty(leitura))
                {
                    return leitura;
                }
                else
                {
                    Console.WriteLine("Entrada invalida!");
                }
            }
        }

        public int LerInt(string pergunta)
        {
            while (true)
            {
                Console.Write(pergunta);

                bool i = int.TryParse(Console.ReadLine(), out int numeros);

                if (i)
                {
                    return numeros;
                }
                else
                {
                    Console.WriteLine("Valor invalido!");
                    Console.WriteLine("Apenas Números!");
                }
            }
        }

        public DateTime LerData(string pergunta)
        {
            while (true)
            {
                Console.WriteLine($"{pergunta} > DD/MM/AAAA < :");
                DateTime data = DateTime.Parse(Console.ReadLine());

                DateTime dataNow = DateTime.Now;

                if (data != null && dataNow >= data)
                {
                    return data;
                }
                else
                {
                    Console.WriteLine("Data no formato invalido!");
                    Console.WriteLine("EXEMPLO -> ano/mes/dia  -> 2023/11/21");
                }
            }
        }

        public string LerCPF(string mensagem)
        {

            bool valida = false;

            while (true)
            {
                Console.Write(mensagem);
                string cpf = Console.ReadLine();

                if (!string.IsNullOrEmpty(cpf) && cpf.Count() == 11)
                {
                    valida = TemCPFValido(cpf);
                }

                if (valida)
                {
                    return cpf;
                }
                else
                {
                    Console.WriteLine($" O CPF -> {cpf} é invalido");
                }
            }
        }

        public string LerCNPJ(string mensagem)
        {
            bool valida = false;

            while (true)
            {
                Console.Write(mensagem);
                string cnpj = Console.ReadLine();

                if (!string.IsNullOrEmpty(cnpj) && cnpj.Count() == 14)
                {
                    valida = TemCNPJValido(cnpj);
                }
                if (valida)
                {
                    return cnpj;
                }
                else
                {
                    Console.WriteLine($" O CNPJ -> {cnpj} é invalido");
                }
            }
        }

        public int CalculaIdade(DateTime dataNacimento)
        {
            DateTime dataNow = DateTime.Now;

            int idade = dataNow.Year - dataNacimento.Year;

            if (dataNow.Month < dataNacimento.Month)
            {
                return idade - 1;
            }
            else if (dataNow.Month == dataNacimento.Month)
            {
                if (dataNow.Day < dataNacimento.Day)
                {
                    return idade - 1;
                }
            }
            return idade;
        }

        public bool TemCPFValido(string cpf)
        {
            // desenvolvover o cálculo de modulo 11 para validação do CPF
            // http://www.bosontreinamentos.com.br/logica-de-programacao/algoritmo-para-validacao-de-cpf-digitos-verificadores-logica-de-programacao/

            int[] multp1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multp2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string numCPF;
            string nVerf;
            int soma = 0;
            int subtracao;
            int sobra;

            numCPF = cpf.Substring(0, 9);
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(numCPF[i].ToString()) * multp1[i];
            }

            sobra = soma % 11;
            subtracao = (11 - sobra) % 10;


            nVerf = subtracao.ToString();

            numCPF = cpf.Substring(0, 10);

            soma = 0;


            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(numCPF[i].ToString()) * multp2[i];
            }

            sobra = soma % 11;
            subtracao = (11 - sobra) % 10;

            nVerf += subtracao.ToString();

            numCPF = cpf.Substring(0, 9) + nVerf.ToString();

            if (cpf == numCPF)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TemCNPJValido(string cnpj)
        {

            int[] multp1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multp2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string numCNPJ;
            string nVerf;
            int soma = 0;
            int subtracao;
            int sobra;

            numCNPJ = cnpj.Substring(0, 12);
            for (int i = 0; i < 12; i++)
            {
                soma += int.Parse(numCNPJ[i].ToString()) * multp1[i];
            }

            sobra = soma % 11;
            subtracao = (11 - sobra) % 10;


            nVerf = subtracao.ToString();

            numCNPJ = cnpj.Substring(0, 13);

            soma = 0;


            for (int i = 0; i < 13; i++)
            {
                soma += int.Parse(numCNPJ[i].ToString()) * multp2[i];
            }

            sobra = soma % 11;
            subtracao = (11 - sobra) % 10;

            nVerf += subtracao.ToString();

            numCNPJ = cnpj.Substring(0, 12) + nVerf.ToString();

            if (cnpj == numCNPJ)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public void LimpConsl()
        {
            Console.Clear();
        }

        public int LerOpcaoTipo(string tipo)
        {
            while (true)
            {
                Console.WriteLine("************************************" +
                            $"\n Qual opção deseja acessar? " +
                            $"\n  -> 1 - {tipo} de Pessoas " +
                            $"\n  -> 2 - {tipo} de Empresas " +
                            $"\n  -> 3 - {tipo} de Usuarios " +
                            $"\n  -> 4 - Voltar " +
                            $"\n************************************");

                bool i = int.TryParse(Console.ReadLine(), out int numeros);

                if (i)
                {
                    return numeros;
                }
                else
                {
                    Console.WriteLine("Valor invalido!");
                    Console.WriteLine("Apenas Números!");
                }
            }

        }

    }
}
