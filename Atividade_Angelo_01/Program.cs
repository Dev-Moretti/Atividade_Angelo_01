using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Angelo_01
{
    internal class Program
    { 
        static List<Pessoa> listPessoas = new List<Pessoa>();
    
        static public void Cadastrar(int tipoCad)
        {
            UtilClass util = new UtilClass();

            string nome;
            string sobrenome;
            DateTime dataNascimento;
            int idade;
            string cpf;
            string rg;
            string endereco;
            string telefone;
            string cnpj;
            string user;
            string senha;


            switch (tipoCad)
            {
                case 1: // cadastro de pessoa

                    nome = util.LerString("Digite seu nome: ");
                    sobrenome = util.LerString("Digite seu sobrenome: ");
                    dataNascimento = util.LerData("Digite a data de nascimento: "); // retorna o nascimento {dd/mm/aaaa 00:00:00} 
                    idade = util.CalculaIdade(dataNascimento);
                    Console.WriteLine($"Idade é de {idade} anos"); // Carregar a data de nascimento e calcular a idade
                    cpf = util.LerCPF("Digite o CPF: ");
                    rg = util.LerString("Digite o RG: ");
                    endereco = util.LerString("Digite o endereço: ");
                    telefone = util.LerString("Digite o numero do telefone/celular: ");
                                        
                    listPessoas.Add(new Pessoa(1, nome, sobrenome, dataNascimento, idade, cpf, rg, endereco, telefone));
                    listPessoas.Add(new Pessoa(2, "Alisson", sobrenome, dataNascimento, idade, cpf, rg, endereco, telefone));

                    Console.WriteLine(listPessoas.Find(p => p.Codigo == 1));

                    break;

                case 2: // cadastro de empresa

                    nome = util.LerString("Digite o nome da empresa: ");
                    dataNascimento = util.LerData("Digite a data de abertura: ");
                    cnpj = util.LerCNPJ("Digite o CNPJ da empresa: ");
                    endereco = util.LerString("Digite o endereço: ");
                    telefone = util.LerString("Digite o telefone: ");


                break;

                case 3: // cadastro de user

                    user = util.LerString("Digite o nome de usuario: ");
                    senha = util.LerString("Digite a senha: ");

                break;

            }

           
            //armazenar a pessoa 
            // List<Pessoa> pessoaList = new List<Pessoa> { new Pessoa(nome, sobrenome, datanascimento, cpf, rg, endereco) };



        }

        static public int MenuCadastrar()
        {
            Console.Write("Qual cadastro dejesa acessar? " +
                            "\n 1 -> Cadastro de Pessoa" +
                            "\n 2 -> Cadastro de Empresa" +
                            "\n 3 -> Cadastro de Usuario \n");

             return int.Parse(Console.ReadLine());
        }
        
        static public int MenuLeitura()
        {
            Console.Write("Qual leitura dejesa acessar? " +
                            "\n 1 -> Leirura de Pessoas" +
                            "\n 2 -> Leitura de Empresas" +
                            "\n 3 -> Leitura de Usuarios \n");

             return int.Parse(Console.ReadLine());
        }

        static public void LerCadastro(int tipoCad)
        {
            //Console.Clear();
            
            Controller c = new Controller();

            switch (tipoCad)
            {
                case 1:
                    Console.WriteLine(c.GetCadPessoa());

                break;

                case 2:


                break;

                case 3:


                break;






            }





        }

        static void Main(string[] args)
        {
           
            Cadastrar(MenuCadastrar());

            LerCadastro(MenuLeitura());

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
