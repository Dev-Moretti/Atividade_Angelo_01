using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Atividade_Angelo_01.Dao
{
    internal class DaoPessoa
    {
        public DaoPessoa() { }

        public void SetPessoa(int codigo, string nome, string sobrenome, DateTime dataNasc, int idade, string cpf, string rg, string endereco, string telefone) 
        {
            string path = $"{System.Environment.CurrentDirectory.ToString()}" + @"\Pessoas.txt";

            string escrita = $"\n{codigo},{nome},{sobrenome},{dataNasc.ToString("dd/MM/yyyy")},{idade},{cpf},{rg},{endereco},{telefone}";

            string arq = File.ReadAllText(path);

            File.WriteAllText(path, (arq + escrita));
        }

        public List<string> GetPessoa()
        {
            string path = $"{System.Environment.CurrentDirectory.ToString()}" + @"\Pessoas.txt";

            List<string> list = new List<string>();

            string arq = File.ReadAllText(path);

            list.Add(arq);

            return list;
        }

    }
}
