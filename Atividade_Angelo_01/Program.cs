using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Angelo_01
{
    internal class Program
    {
        static public void Cadastrar(int tipocad)
        {
            UtilClass util = new UtilClass();

            string nome;
            string sobrenome;
            DateTime dataNascimento;
            string cpf;
            string rg;
            string endereco;
            int telefone;
            string cnpj;
            string user;
            string senha;


            switch (tipocad)
            {
                case 1: // cadastro de pessoa

                    nome = util.LerString("Digite seu nome: ");
                    sobrenome = util.LerString("Digite seu sobrenome: ");
                    dataNascimento = util.LerData("Digite a data de nascimento: "); // retorna o nascimento {dd/mm/aaaa 00:00:00} 
                    Console.WriteLine($"Idade é de {util.CalculaIdade(dataNascimento)} anos"); // Carregar a data de nascimento e calcular a idade
                    cpf = util.LerCPF("Digite o CPF: ");
                    rg = util.LerString("Digite o RG: ");
                    endereco = util.LerString("Digite o endereço: ");
                    telefone = util.LerInt("Digite o numero do telefone/celular: ");

                break;

                case 2: // cadastro de empresa

                    nome = util.LerString("Digite o nome da empresa: ");
                    dataNascimento = util.LerData("Digite a data de abertura: ");
                    Console.WriteLine($"Empresa aberta há {util.CalculaIdade(dataNascimento)} anos");
                    cnpj = util.LerCNPJ("Digite o CNPJ da empresa: ");
                    endereco = util.LerString("Digite o endereço: ");
                    telefone = util.LerInt("Digite o telefone: ");

                break;

                case 3: // cadastro de user

                    user = util.LerString("Digite o nome de usuario: ");
                    senha = util.LerString("Digite a senha: ");

                break;

            }

           
            //armazenar a pessoa 
            // List<Pessoa> pessoaList = new List<Pessoa> { new Pessoa(nome, sobrenome, datanascimento, cpf, rg, endereco) };



        }

        static public int Menu()
        {
            Console.Write("Digite o numero da opção: " +
                            "\n 1 -> Cadastro de Pessoa" +
                            "\n 2 -> Cadastro de Empresa" +
                            "\n 3 -> Cadastro de Usuario \n");

             return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int i = Menu();
            Cadastrar(i);


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
