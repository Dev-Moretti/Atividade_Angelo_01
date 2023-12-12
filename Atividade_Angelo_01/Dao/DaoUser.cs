using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Atividade_Angelo_01.Dao
{
    internal class DaoUser
    {
        static string pathUser = $"{System.Environment.CurrentDirectory.ToString()}" + @"\User.json";

        public void SetUser(User user)
        {
            List<string> listUser = File.ReadAllLines(pathUser).ToList();

            listUser.Add(user.ToFilePessoa());

            File.WriteAllText(pathUser, Newtonsoft.Json.JsonConvert.SerializeObject(listUser));
        }

        public List<User> GetUser()
        {
            if (!File.Exists(pathUser))
            {
                File.WriteAllText(pathUser, "");
            }

            List<User> listUser = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(pathUser));

            return listUser;
        }

        public bool RemoveUser(int cod)
        {
            List<User> listUser = GetUser();

            if (listUser.Remove(listUser.Find(p => p.Codigo == cod)))
            {
                List<string> temp = new List<string>();

                foreach (User u in listUser)
                {
                    temp.Add(u.ToFileUser());
                }

                File.WriteAllText(pathUser, Newtonsoft.Json.JsonConvert.SerializeObject(temp));

                return true;
            }
            return false;
        }

    }
}