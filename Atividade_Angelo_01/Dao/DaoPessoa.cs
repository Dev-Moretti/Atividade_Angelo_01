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

        static string pathPessoa = $"{System.Environment.CurrentDirectory.ToString()}" + @"\Pessoas.json";
        
        public void SetPessoa(Pessoa pessoa)
        {
            List<string> listPessoa = File.ReadAllLines(pathPessoa).ToList();

            listPessoa.Add(pessoa.ToFilePessoa());

            File.WriteAllText(pathPessoa, Newtonsoft.Json.JsonConvert.SerializeObject(listPessoa));
        }

        public List<Pessoa> GetPessoa()
        {
            // forma melhorada de fazer -- usando Jason -- precisa do Newtonsoft do nuguet

            if (!File.Exists(pathPessoa))
            {
                File.WriteAllText(pathPessoa, "");
            }

            List<Pessoa> listPessoa = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Pessoa>>(File.ReadAllText(pathPessoa));

            return listPessoa;


            // ------ forma que eu fiz "gambiarra" com .txt

            //if (!File.Exists(pathPessoa))
            //{
            //File.WriteAllText(pathPessoa, "");
            //}

            //List<Pessoa> listPessoa = new List<Pessoa>();

            //List<string> arq = File.ReadAllLines(pathPessoa).ToList();

            //foreach (string line in arq)
            //{
            //    string[] dadosPessoa = line.Split(',');

            //    listPessoa.Add(new Pessoa(
            //        int.Parse(dadosPessoa[0]), 
            //        dadosPessoa[1], 
            //        dadosPessoa[2], 
            //        DateTime.Parse(dadosPessoa[3]), 
            //        int.Parse(dadosPessoa[4]), 
            //        dadosPessoa[5], 
            //        dadosPessoa[6], 
            //        dadosPessoa[7], 
            //        dadosPessoa[8])
            //        );
            //}
        }

        public bool RemovePessoa(int cod)
        {
            List<Pessoa> listPessoas = GetPessoa();

            //Remover da lista
            if (listPessoas.Remove(listPessoas.Find(p => p.Codigo == cod)))
            {
                List<string> temp = new List<string>();

                foreach (Pessoa p in listPessoas)
                {
                    temp.Add(p.ToFilePessoa());
                }

                File.WriteAllText(pathPessoa, Newtonsoft.Json.JsonConvert.SerializeObject(temp));

                return true;
            }
            return false;
        }


    }
}
