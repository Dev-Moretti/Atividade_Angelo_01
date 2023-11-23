using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Angelo_01
{
    internal class User : Pessoa
    {
        public string NomeUser { get; private set; }

        public string SenhaUser { get; private set; }



        public User(string nomeUsu, string senhaUsu)
        {
            if (nomeUsu != null)
            {
                NomeUser = nomeUsu;
                SenhaUser = senhaUsu;
            }
        }

        public bool LoguinUser(string user, string senha)
        {
            if (NomeUser == user)
            {
                if (SenhaUser == senha)
                {
                    return true;
                }
                else 
                { 
                    return false; 
                }
            }
            else 
            { 
                return false; 
            }

        }


    }
}
