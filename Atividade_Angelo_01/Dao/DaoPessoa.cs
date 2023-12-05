using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Diagnostics.Contracts;

namespace Atividade_Angelo_01.Dao
{
    internal class DaoPessoa
    {
        public DaoPessoa() { }

        static string pathPessoa = $"{System.Environment.CurrentDirectory.ToString()}" + @"\Pessoas.txt";
        static string pathEmpresa = $"{System.Environment.CurrentDirectory.ToString()}" + @"\Empresas.txt";
        static string pathUser = $"{System.Environment.CurrentDirectory.ToString()}" + @"\User.txt";

        public void SetPessoa(Pessoa pessoa)
        {
            List<string> listPessoa = File.ReadAllLines(pathPessoa).ToList();
            
            listPessoa.Add(pessoa.ToFilePessoa());

            File.WriteAllLines(pathPessoa, listPessoa);
        }

        public void SetEmpresa(Empresa empresa)
        {
            List<string> listEmpresa = File.ReadAllLines(pathEmpresa).ToList();

            listEmpresa.Add(empresa.ToFileEmpresa());

            File.WriteAllLines(pathEmpresa, listEmpresa);
        }

        public void SetUser(User user)
        {
            List<string> listUser = File.ReadAllLines(pathUser).ToList();

            listUser.Add(user.ToFileUser());

            File.WriteAllLines(pathUser, listUser);
        }

        public List<Pessoa> GetPessoa()
        {
            if(!File.Exists(pathPessoa))
            {
                File.WriteAllText(pathPessoa, "");
            }

            List<Pessoa> listPessoa = new List<Pessoa>();

            List<string> arq = File.ReadAllLines(pathPessoa).ToList();

            foreach (string line in arq)
            {
                string[] dadosPessoa = line.Split(',');

                listPessoa.Add(new Pessoa(
                    int.Parse(dadosPessoa[0]), 
                    dadosPessoa[1], 
                    dadosPessoa[2], 
                    DateTime.Parse(dadosPessoa[3]), 
                    int.Parse(dadosPessoa[4]), 
                    dadosPessoa[5], 
                    dadosPessoa[6], 
                    dadosPessoa[7], 
                    dadosPessoa[8])
                    );
            }
            return listPessoa;
        }

        public List<Empresa> GetEmpresa()
        {
            if (!File.Exists(pathEmpresa))
            {
                File.WriteAllText(pathEmpresa, "");
            }

            List<Empresa> listEmpresa = new List<Empresa>();

            List<string> arq = File.ReadAllLines(pathPessoa).ToList();

            foreach (string line in arq)
            {
                string[] dadosEmpresa = line.Split(',');

                listEmpresa.Add(new Empresa(
                    int.Parse(dadosEmpresa[0]),
                    dadosEmpresa[1],
                    dadosEmpresa[2],
                    dadosEmpresa[3],
                    dadosEmpresa[4])
                    );
            }
            return listEmpresa;
        }

        public List<User> GetUser() 
        {
            if (!File.Exists(pathUser))
            {
                File.WriteAllText(pathUser, "");
            }

            List<User> listUser = new List<User>();

            List<string> arq = File.ReadAllLines(pathPessoa).ToList();

            foreach(string line in arq)
            {
                string[] dadosUser = line.Split(',');
                listUser.Add(new User(
                    int.Parse(dadosUser[0]),
                    dadosUser[1],
                    dadosUser[2])
                    );
            }
            return listUser;
        }
    
        public void SetRemovePessoa(List<Pessoa> pessoa)
        {
            
            File.WriteAllLines(pathPessoa, pessoa);






        }
    
    
    
    }


}
