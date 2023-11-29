using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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



        static void MenuPrincipal()
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

                                util.LimpConsl();
                                Cadastro();

                                break;

                            case 2:

                                util.LimpConsl();
                                Listagem();

                                break;

                            case 3:

                                util.LimpConsl();
                                Busca();

                                break;

                            case 4:

                                util.LimpConsl();
                                Remove();

                                break;

                            case 5:
                                parar = true;
                                break;
                        }
                    }
                }
            }


        }

        static void Cadastro()
        {
            int escolha = 4;

            do
            {
                escolha = util.LerOpcaoTipo("Cadastro");

                switch (escolha)
                {
                    case 1:

                        util.LimpConsl();
                        CadastroPessoa();

                        break;

                    case 2:

                        util.LimpConsl();
                        CadastroEmpresa();

                        break;

                    case 3:

                        util.LimpConsl();
                        CadastroUser();

                        break;

                    case 4:

                        util.LimpConsl();
                        Console.Write("VOLTANDO...");
                        System.Threading.Thread.Sleep(1000);

                        break;

                    default:

                        Console.WriteLine("Opção Invalida!!");

                        break;
                }


            } while (escolha != 4);
        }

        static void CadastroPessoa()
        {
            Console.WriteLine("Cadastrando pessoa:");
            int codigo = util.LerInt("Digite o codigo da pessoa a ser cadastrada: ");
            string nome = util.LerString("Digite o nome: ");
            string sobrenome = util.LerString("Digite o sobrenome: ");
            DateTime dataNascimento = util.LerData("Digite a data de nascimento: "); // retorna o nascimento {dd/mm/aaaa 00:00:00} 
            int idade = util.CalculaIdade(dataNascimento);
            Console.WriteLine($"Idade é de {idade} anos"); // Carregar a data de nascimento e calcular a idade
            string cpf = util.LerCPF("Digite o CPF: ");
            string rg = util.LerString("Digite o RG: ");
            string endereco = util.LerString("Digite o endereço: ");
            string telefone = util.LerString("Digite o numero do telefone/celular: ");

            listPessoas.Add(new Pessoa(codigo, nome, sobrenome, dataNascimento, idade, cpf, rg, endereco, telefone));
        }

        static void CadastroEmpresa()
        {
            Console.WriteLine("Cadastrando empresa:");
            int codigo = util.LerInt("Digite o codigo da empresa: ");
            string nome = util.LerString("Digite o nome da empresa: ");
            string cnpj = util.LerCNPJ("Digite o CNPJ da empresa: ");
            string endereco = util.LerString("Digite o endereço: ");
            string telefone = util.LerString("Digite o telefone: ");

            listEmpresa.Add(new Empresa(codigo, nome, cnpj, endereco, telefone));
        }

        static void CadastroUser()
        {
            Console.WriteLine("Cadastrando Usuario:");
            int codigo = util.LerInt("Digite o codigo do usuario: ");
            string user = util.LerString("Digite o nome de usuario: ");
            string senha = util.LerString("Digite a senha: ");

            listUser.Add(new User(codigo, user, senha));
        }

        static void Listagem()
        {
            int escolha = 4;

            do
            {

                escolha = util.LerOpcaoTipo("Listagem");

                switch (escolha)
                {
                    case 1:

                        util.LimpConsl();
                        ListagemPessoa();

                        break;

                    case 2: // empresa

                        util.LimpConsl();
                        ListagemEmpresa();

                        break;

                    case 3:  // usuario

                        util.LimpConsl();
                        ListagemUsuario();

                        break;

                    case 4:
                        Console.WriteLine("VOLTANDO...");
                        System.Threading.Thread.Sleep(1000);
                        util.LimpConsl();
                        break;

                    default:
                        Console.WriteLine("Opção Invalida!!");
                        break;
                }
            } while (escolha != 4);

        }

        static void ListagemPessoa()
        {
            if (listPessoas.Count() != 0)
            {
                foreach (Pessoa pessoa in listPessoas)
                {
                    Console.WriteLine(pessoa);
                }
            }
            else
            {
                Console.WriteLine("Lista vazia!");
            }
        }

        static void ListagemEmpresa()
        {
            if (listEmpresa.Count() != 0)
            {
                foreach (Empresa empresa in listEmpresa)
                {
                    Console.WriteLine(empresa);
                }
            }
            else
            {
                Console.WriteLine("Lista vazia!");
            }
        }

        static void ListagemUsuario()
        {
            if (listUser.Count() != 0)
            {
                foreach (User user in listUser)
                {
                    Console.WriteLine(user);
                }
            }
            else
            {
                Console.WriteLine("Lista vazia!");
            }
        }

        static void Busca()
        {
            int escolha = 4;
            do
            {
                escolha = util.LerOpcaoTipo("Busca");

                switch (escolha)
                {
                    case 1:
                        util.LimpConsl();
                        BuscarPessoa();
                        break;

                    case 2:
                        util.LimpConsl();
                        BuscarEmpresa();
                        break;

                    case 3:

                        util.LimpConsl();
                        BuscarUsuario();
                        break;

                    case 4:
                        Console.WriteLine("VOLTANDO...");
                        System.Threading.Thread.Sleep(1000);
                        util.LimpConsl();
                        break;

                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }
            } while (escolha != 4);
        }

        static void BuscarPessoa()
        {
            int escolha = 6;
            do
            {
                Console.WriteLine("__________________________");
                Console.WriteLine("\nEscolha os filtros: ");
                Console.WriteLine("__________________________");
                Console.WriteLine("\n -> 1 - Codigo "
                                  + "\n -> 2 - Nome "
                                  + "\n -> 3 - Sobrenome "
                                  + "\n -> 4 - Telefone "
                                  + "\n -> 5 - CPF "
                                  + "\n -> 6 - VOLTAR \n");

                int.TryParse(Console.ReadLine(), out escolha);

                switch (escolha)
                {
                    //codigo
                    case 1:
                        int cod = util.LerInt("Digite o Codigo: ");

                        pessoa = listPessoas.Find(p => p.Codigo == cod);

                        if (pessoa != null)
                        {
                            Console.WriteLine(pessoa.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"-> {cod} <- não encontrado!");
                        }
                        break;
                    //nome
                    case 2:
                        string nome = util.LerString("Digite o Nome: ");

                        pessoa = listPessoas.Find(p => p.Nome == nome);

                        if (pessoa != null)
                        {
                            Console.WriteLine(pessoa.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"-> {nome} <- não encontrado!");
                        }
                        break;
                    //sobrenome
                    case 3:
                        string sobrenome = util.LerString("Digite o Sobrenome: ");

                        pessoa = listPessoas.Find(p => p.Sobrenome == sobrenome);

                        if (pessoa != null)
                        {
                            Console.WriteLine(pessoa.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"-> {sobrenome} <- não encontrado!");
                        }
                        break;
                    //telefone
                    case 4:
                        string telefone = util.LerString("Digite o Telefone: ");

                        pessoa = listPessoas.Find(p => p.Telefone == telefone);

                        if (pessoa != null)
                        {
                            Console.WriteLine(pessoa.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"-> {telefone} <- não encontrado!");
                        }
                        break;
                    //CPF
                    case 5:
                        string cpf = util.LerCPF("Digite o CPF: ");

                        pessoa = listPessoas.Find(p => p.CPF == cpf);

                        if (pessoa != null)
                        {
                            Console.WriteLine(pessoa.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"-> {cpf} <- não encontrado!");
                        }
                        break;
                    //Sair
                    case 6:
                        Console.WriteLine("VOLTANDO...");
                        System.Threading.Thread.Sleep(1000);
                        util.LimpConsl();
                        break;

                    default:
                        Console.WriteLine("Opção invalida!!");
                        break;
                }
            } while (escolha == 6);
        }

        static void BuscarEmpresa()
        {
            int escolha = 5;
            do
            {
                Console.WriteLine("__________________________");
                Console.WriteLine("\nEscolha um dos filtros: ");
                Console.WriteLine("__________________________");
                Console.WriteLine("\n -> 1 - Codigo "
                                  + "\n -> 2 - Nome "
                                  + "\n -> 3 - Telefone "
                                  + "\n -> 4 - CNPJ "
                                  + "\n -> 5 - VOLTAR \n");

                int.TryParse(Console.ReadLine(), out escolha);

                switch (escolha)
                {
                    //Cod
                    case 1:
                        int cod = util.LerInt("Digite o Codigo: ");

                        empresa = listEmpresa.Find(p => p.Codigo == cod);

                        if (empresa != null)
                        {
                            Console.WriteLine(empresa.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"-> {cod} <- não encontrado!");
                        }
                        break;
                    //Nome
                    case 2:
                        string nome = util.LerString("Digite o Nome: ");

                        empresa = listEmpresa.Find(p => p.Nome == nome);

                        if (empresa != null)
                        {
                            Console.WriteLine(empresa.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"-> {nome} <- não encontrado!");
                        }
                        break;
                    //Telefone
                    case 3:
                        string telefone = util.LerString("Digite o Telefone: ");

                        empresa = listEmpresa.Find(p => p.Telefone == telefone);

                        if (empresa != null)
                        {
                            Console.WriteLine(empresa.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"-> {telefone} <- não encontrado!");
                        }

                        break;
                    //CNPJ
                    case 4:
                        string cnpj = util.LerCPF("Digite o CNPJ: ");

                        empresa = listEmpresa.Find(p => p.CNPJ == cnpj);

                        if (empresa != null)
                        {
                            Console.WriteLine(empresa.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"-> {cnpj} <- não encontrado!");
                        }
                        break;
                    //Sair
                    case 5:
                        Console.WriteLine("VOLTANDO");
                        System.Threading.Thread.Sleep(1000);
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida!");
                        break;
                }

            } while (escolha != 5);
        }

        static void BuscarUsuario()
        {
            int escolha = 3;
            do
            {
                Console.WriteLine("__________________________");
                Console.WriteLine("Escolha um dos filtros:");
                Console.WriteLine("__________________________");
                Console.WriteLine("\n -> 1 - Codigo "
                                  + "\n -> 2 - User "
                                  + "\n -> 3 - VOLTAR \n");

                int.TryParse(Console.ReadLine(), out escolha);

                switch (escolha)
                {
                    //cod
                    case 1:
                        int cod = util.LerInt("Digite o Codigo: ");

                        user = listUser.Find(p => p.Codigo == cod);

                        if (user != null)
                        {
                            Console.WriteLine(user.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"-> {cod} <- não encontrado!");
                        }
                        break;
                    //nome
                    case 2:
                        string nome = util.LerString("Digite o Nome: ");

                        user = listUser.Find(p => p.Nome == nome);

                        if (user != null)
                        {
                            Console.WriteLine(user.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"-> {nome} <- não encontrado!");
                        }
                        break;
                    //sair
                    case 3:
                        Console.WriteLine("VOLTANDO");
                        System.Threading.Thread.Sleep(1000);
                        util.LimpConsl();
                        break;
                    default:
                        Console.WriteLine("Opção Invalida!");
                        break;
                }
            } while (escolha != 3);
        }

        static void Remove()
        {
            int escolha = util.LerOpcaoTipo("Remover");
            do
            {
                switch (escolha)
                {
                    //pessoa
                    case 1:
                        util.LimpConsl();
                        RemovePessoa();
                        break;

                    //empresa
                    case 2:
                        util.LimpConsl();
                        RemoveEmpresa();
                        break;

                    //usuario
                    case 3:
                        util.LimpConsl();
                        RemoveUsuario();
                        break;

                    //sair
                    case 4:
                        Console.WriteLine("VOLTANDO ...");
                        System.Threading.Thread.Sleep(1000);
                        util.LimpConsl();
                        break;

                    default:
                        Console.WriteLine("Opção Invalida!");
                        break;
                }

            } while (escolha != 4);
        }

        static void RemovePessoa()
        {
            ListagemPessoa();
            int cod = util.LerInt("Digite o Codigo: ");
            pessoa = listPessoas.Find(p => p.Codigo == cod);
            
            if (pessoa != null)
            {
                Console.WriteLine(pessoa);
                string resposta = util.LerString("Deseja deletar?  -> sim / nao <- ");
                if (resposta == "sim")
                {
                    listPessoas.Remove(pessoa);
                }
            }
            else
            {
                Console.WriteLine($"->  {cod}  <- Não foi encontrado!");
            }

            util.LimpConsl();
            ListagemPessoa();
        }

        static void RemoveEmpresa()
        {
            ListagemEmpresa();
            int cod = util.LerInt("Digite o Codigo: ");
            empresa = listEmpresa.Find(p => p.Codigo == cod);

            if(empresa != null)
            {
                Console.WriteLine(empresa);
                string resposta = util.LerString("Deseja deletar?  -> sim / nao <- ");
                if (resposta == "sim")
                {
                    listPessoas.Remove(pessoa);
                }
            }
            else
            {
                Console.WriteLine($"->  {cod}  <- Não foi encontrado!");
            }
            util.LimpConsl();
            ListagemEmpresa();
        }

        static void RemoveUsuario()
        {
            ListagemUsuario();
            int cod = util.LerInt("Digite o Codigo: ");
            user = listUser.Find(p => p.Codigo == cod);

            if (user != null)
            {
                Console.WriteLine(user);
                string resposta = util.LerString("Deseja deletar?  -> sim / nao <- ");
                if (resposta == "sim")
                {
                    listUser.Remove(user);
                }
            }
            else
            {
                Console.WriteLine($"->  {cod}  <- Não foi encontrado!");
            }
            util.LimpConsl();
            ListagemEmpresa();
        }

        static void Main(string[] args)
        {
            MenuPrincipal();

        }
    }
}