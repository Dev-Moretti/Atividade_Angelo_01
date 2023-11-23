using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Angelo_01
{
    internal class Controller
    {

        public Controller()
        {

        }


        public bool TemCPFValido(string cpf)
        {
            Pessoa pessoa = new Pessoa();

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

    }
}
