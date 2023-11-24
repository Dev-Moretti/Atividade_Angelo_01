using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        static List<Empresa> listEmpresa = new List<Empresa>();
        static List<User> listUser = new List<User>();

        static UtilClass util = new UtilClass();

        static void MenuPrincipal()
        {
            util.LimpConsl();

            bool parar = false;
            int escolha;

            while (parar == false)
            {
                Console.WriteLine("Digite a opção desejada!");
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
                                MenuCadastrar();
                                break;

                            case 2:
                                MenuListagem();
                                break;

                            case 3:
                                MenuBuscar();
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

        static void MenuCadastrar()
        {
            util.LimpConsl();

            bool parar = false;

            while (parar == false)
            {
                Console.WriteLine("_________________________");
                Console.WriteLine("Qual cadastro deseja acessar? " +
                                "\n  -> 1 - Cadastro de Pessoa "  +
                                "\n  -> 2 - Cadastro de Empresa " +
                                "\n  -> 3 - Cadastro de Usuario " +
                                "\n  -> 4 - Voltar ");
                Console.WriteLine("_________________________");
                int escolha;

                int.TryParse(Console.ReadLine(), out escolha);

                if (escolha == 0)
                {
                    parar = false;
                }

                if (escolha > 0 && escolha <= 3)
                {
                    Cadastrar(escolha);
                    parar = true;
                }

                if (escolha == 4)
                {
                    MenuPrincipal();
                    parar = true;
                }

            }
        }

        static void Cadastrar(int tipoCad)
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

            util.LimpConsl();

            switch (tipoCad)
            {
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
                    MenuPrincipal();

                    break;

                case 2: // cadastro de empresa

                    Console.WriteLine("Cadastrando empresa:");
                    codigo = util.LerInt("Digite o codigo da empresa: ");
                    nome = util.LerString("Digite o nome da empresa: ");
                    cnpj = util.LerCNPJ("Digite o CNPJ da empresa: ");
                    endereco = util.LerString("Digite o endereço: ");
                    telefone = util.LerString("Digite o telefone: ");

                    listEmpresa.Add(new Empresa(codigo, nome, cnpj, endereco, telefone));
                    MenuPrincipal();

                    break;

                case 3: // cadastro de user
                    Console.WriteLine("Cadastrando Usuario:");
                    codigo = util.LerInt("Digite o codigo do usuario: ");
                    user = util.LerString("Digite o nome de usuario: ");
                    senha = util.LerString("Digite a senha: ");

                    listUser.Add(new User(codigo, user, senha));
                    MenuPrincipal();

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
                        MenuBuscar();
                        parar = true;
                    }

                }
                if (escolha == 4)
                {
                    parar = true;
                    MenuPrincipal();
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

        static void MenuBuscar()
        {
            int escolha;
            bool parar = false;


            while (parar == false)
            {
                Console.WriteLine("Escolha um dos filtros: ");
                Console.WriteLine("__________________________");
                Console.WriteLine(  "\n -> 1 - Codigo " 
                                  + "\n -> 2 - Nome " 
                                  + "\n -> 3 - Sobrenome " 
                                  + "\n -> 4 - Telefone " 
                                  + "\n -> 5 - CPF " 
                                  + "\n -> 6 - CNPJ " 
                                  + "\n -> 7 - VOLTAR \n");

                int.TryParse(Console.ReadLine(), out escolha);

                if (escolha == 0)
                {
                    parar = false;
                }
                else
                {
                    parar = true;

                    switch (escolha)
                    {
                        case 1:
                            int cod = util.LerInt("Digite o Codigo: ");

                            Console.WriteLine(listPessoas.Find(p => p.Codigo == cod));


                            break;

                        
                    }
                }
            }
            


        }


        static void Main(string[] args)
        {

            MenuPrincipal();

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