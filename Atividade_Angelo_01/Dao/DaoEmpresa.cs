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
    internal class DaoEmpresa
    {
        public DaoEmpresa() { }

        static string pathEmpresa = $"{System.Environment.CurrentDirectory.ToString()}" + @"\Empresas.json";

        public void SetEmpresa(Empresa empresa)
        {
            List<string> listEmpresa = File.ReadAllLines(pathEmpresa).ToList();

            listEmpresa.Add(empresa.ToFileEmpresa());

            File.WriteAllText(pathEmpresa, Newtonsoft.Json.JsonConvert.SerializeObject(listEmpresa));
        }

        public List<Empresa> GetEmpresa()
        {
            if (!File.Exists(pathEmpresa))
            {
                File.WriteAllText(pathEmpresa, "");
            }

            List<Empresa> listEmpresa = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Empresa>>(File.ReadAllText(pathEmpresa));

            return listEmpresa;
        }

        public bool RemoveEmpresa(int cod)
        {
            List<Empresa> listEmpresa = GetEmpresa();

            //Remover da lista
            if (listEmpresa.Remove(listEmpresa.Find(p => p.Codigo == cod)))
            {
                List<string> temp = new List<string>();

                foreach (Empresa p in listEmpresa)
                {
                    temp.Add(p.ToFilePessoa());
                }

                File.WriteAllText(pathEmpresa, Newtonsoft.Json.JsonConvert.SerializeObject(temp));

                return true;
            }
            return false;
        }

    }
}
