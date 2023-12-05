using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Atividade_Angelo_01.Dao
{
    internal class SalvarPessoa 
    {
        private const string arqPessoas = @"\Pessoas.txt";

        public SalvarPessoa() { }
        public void SetPessoa(List<Pessoa>list)
        {
            //string pessoa = ($"\n{Codigo},{nome},{sobrenome},{dataNasc},{idade},{cpf},{rg},{endereco},{telefone}");
            
            string pessoa = list.ToString();
            // problema na lista de pessoas que vem da main



            // pega o caminho local da execução do arquivo
            string path = $"{System.Environment.CurrentDirectory.ToString()}{arqPessoas}";

            File.AppendAllText(path, pessoa);
        }



    }
}
