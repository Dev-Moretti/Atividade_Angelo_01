using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Angelo_01
{
    internal class Program
    {
        static List<Pessoa> listPessoas = new List<Pessoa>();
        static List<Empresa> listEmpresa = new List<Empresa>();
        static List<User> listUser = new List<User>();

        static UtilClass util = new UtilClass();
        static Pessoa pessoa = new Pessoa();
        static Empresa empresa = new Empresa();
        static User user = new User();

        static void OqueFazer()
        {
            util.LimpConsl();

            bool parar = false;
            int escolha;

            while (parar == false)
            {
                Console.WriteLine("\nDigite a opção desejada!");
                Console.WriteLine("_________________________");
                Console.WriteLine("  -> 1 - Cadastros " +
                                "\n  -> 2 - Listagens " +
                                "\n  -> 3 - Buscar    " +
                                "\n  -> 4 - Remover   " +
                                "\n  -> 5 - SAIR   ");
                Console.WriteLine("_________________________");

                int.TryParse(Console.ReadLine(), out escolha);
                
                if (escolha <= 5)
                {
                    if (escolha == 0)
                    {
                        parar = false;
                    }
                    else
                    {
                        switch (escolha)
                        {
                            case 1:
                                Cadastrar();
                                break;

                            case 2:
                                MenuListagem();
                                break;

                            case 3:
                                buscarPessoa();
                                break;

                            case 4:
                                //Remover();
                                break;

                            case 5:
                                parar = true;
                                break;
                        }
                    }
                }
            }
        }

        static void Cadastrar()
        {
            int codigo;
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
            
            int escolha = 0;

            util.LimpConsl();

            bool bo = true;

            while (bo == true)
            {
                Console.WriteLine("_________________________");
                Console.WriteLine("Qual cadastro deseja acessar? " +
                                "\n  -> 1 - Cadastro de Pessoa " +
                                "\n  -> 2 - Cadastro de Empresa " +
                                "\n  -> 3 - Cadastro de Usuario " +
                                "\n  -> 4 - Voltar ");
                Console.WriteLine("_________________________");

                int.TryParse(Console.ReadLine(), out escolha);

                if (escolha != 0)
                {
                    bo = false;
                }

                if (escolha == 4)
                {
                    OqueFazer();
                }
            }

            Console.Clear();

            switch (escolha)
            {
                case 0:

                    Console.WriteLine("Invalido!");

                    break;

                case 1: // cadastro de pessoa
                    Console.WriteLine("Cadastrando pessoa:");
                    codigo = util.LerInt("Digite o codigo da pessoa a ser cadastrada: ");
                    nome = util.LerString("Digite o nome: ");
                    sobrenome = util.LerString("Digite o sobrenome: ");
                    dataNascimento = util.LerData("Digite a data de nascimento: "); // retorna o nascimento {dd/mm/aaaa 00:00:00} 
                    idade = util.CalculaIdade(dataNascimento);
                    Console.WriteLine($"Idade é de {idade} anos"); // Carregar a data de nascimento e calcular a idade
                    cpf = util.LerCPF("Digite o CPF: ");
                    rg = util.LerString("Digite o RG: ");
                    endereco = util.LerString("Digite o endereço: ");
                    telefone = util.LerString("Digite o numero do telefone/celular: ");

                    listPessoas.Add(new Pessoa(codigo, nome, sobrenome, dataNascimento, idade, cpf, rg, endereco, telefone));
                    OqueFazer();

                    break;

                case 2: // cadastro de empresa

                    Console.WriteLine("Cadastrando empresa:");
                    codigo = util.LerInt("Digite o codigo da empresa: ");
                    nome = util.LerString("Digite o nome da empresa: ");
                    cnpj = util.LerCNPJ("Digite o CNPJ da empresa: ");
                    endereco = util.LerString("Digite o endereço: ");
                    telefone = util.LerString("Digite o telefone: ");

                    listEmpresa.Add(new Empresa(codigo, nome, cnpj, endereco, telefone));
                    OqueFazer();

                    break;

                case 3: // cadastro de user
                    Console.WriteLine("Cadastrando Usuario:");
                    codigo = util.LerInt("Digite o codigo do usuario: ");
                    user = util.LerString("Digite o nome de usuario: ");
                    senha = util.LerString("Digite a senha: ");

                    listUser.Add(new User(codigo, user, senha));
                    OqueFazer();

                    break;

            }
        }

        static void MenuListagem()
        {
            util.LimpConsl();
            bool parar = false;

            while (parar == false)
            {
                Console.WriteLine("_________________________");
                Console.WriteLine("Qual listagem deseja acessar? " +
                                "\n  -> 1 - Lista de Pessoas "  +
                                "\n  -> 2 - Lista de Empresas " +
                                "\n  -> 3 - Lista de Usuarios " +
                                "\n  -> 4 - Voltar ");
                Console.WriteLine("_________________________");
                
                int escolha;

                int.TryParse(Console.ReadLine(), out escolha);

                if (escolha <= 3)
                {
                    if(escolha == 0)
                    {
                        parar = false;
                    }
                    else
                    {
                        buscarPessoa();
                        parar = true;
                    }

                }
                if (escolha == 4)
                {
                    parar = true;
                    OqueFazer();
                }
            }
        }

        static void Listagem(int escolha)
        {
            util.LimpConsl();

            switch (escolha)
            {
                case 1: // pessoa
                    

                    break;

                case 2: // empresa


                    break;

                case 3:  // usuario


                    break;
            }
        }

        
        //static void Remover()
        //{
        //    switch (escolha)
        //    {
        //        case 1: // pessoa


        //            break;

        //        case 2: // empresa


        //            break;

        //        case 3:  // usuario


        //            break;
        //    }
        //}

        static void buscarPessoa()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("__________________________");
                Console.WriteLine("\nEscolha um dos filtros: ");
                Console.WriteLine("__________________________");
                Console.WriteLine(  "\n -> 1 - Codigo " 
                                  + "\n -> 2 - Nome " 
                                  + "\n -> 3 - Sobrenome " 
                                  + "\n -> 4 - Telefone " 
                                  + "\n -> 5 - CPF " 
                                  + "\n -> 6 - VOLTAR \n");

                int.TryParse(Console.ReadLine(), out int escolha);

                if (escolha != 0)
                {
                    switch (escolha)
                    {
                        case 1:

                            int cod = util.LerInt("Digite o Codigo: ");

                            if (listPessoas.Find(p => p.Codigo == cod) != null)
                            {
                                Console.WriteLine(listPessoas.Find(p => p.Codigo == cod));
                            }
                            else
                            {
                                Console.WriteLine($"->  {cod}  <- Não foi encontrado!");
                            }
                            break;
                        
                        case 2:

                            string nome = util.LerString("Digite o Nome: ");

                            if (listPessoas.Find(p => p.Nome == nome) != null)
                            {
                                Console.WriteLine(listPessoas.Find(p => p.Nome == nome));
                            }
                            else
                            {
                                Console.WriteLine($"->  {nome}  <- Não foi encontrado!");
                            }
                            break;
                        
                        case 3:

                            string sobrenome = util.LerString("Digite o Sobrenome: ");

                            if(listPessoas.Find(p => p.Sobrenome == sobrenome) != null)
                            {
                                Console.WriteLine(listPessoas.Find(p => p.Sobrenome == sobrenome));
                            }
                            else
                            {
                                Console.WriteLine($"->  {sobrenome}  <- Não foi encontrado!");
                            }
                            break;

                        case 4:

                            string telefone = util.LerString("Digite o Telefone: ");

                            if (listPessoas.Find(p => p.Telefone == telefone) != null)
                            {
                                Console.WriteLine(listPessoas.Find(p => p.Telefone == telefone));
                            }
                            else
                            {
                                Console.WriteLine($"->  {telefone}  <- Não foi encontrado!");
                            }
                            break;

                        case 5:

                            string cpf = util.LerCPF("Digite o CPF: ");

                            if(listPessoas.Find(p => p.CPF == cpf) != null)
                            {
                                Console.WriteLine(listPessoas.Find(p => p.CPF == cpf));
                            }
                            else
                            {
                                Console.WriteLine($"->  {cpf}  <- Não foi encontrado!");
                            }
                            break;

                        case 6:

                            Console.WriteLine("VOLTANDO");
                            System.Threading.Thread.Sleep(1000);
                            OqueFazer();
                            break;
                    }
                }
            }
            
        }


        static void Main(string[] args)
        {

            OqueFazer();

           // Console.WriteLine(listPessoas.Find(p => p.Codigo == 1));

            //Cadastrar(MenuCadastrar());

            //LerCadastro(MenuLeitura());

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

        }
    }
}