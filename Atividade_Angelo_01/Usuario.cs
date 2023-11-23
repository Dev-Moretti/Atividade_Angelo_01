using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Angelo_01
{
    internal class Usuario : Pessoa
    {
        public string nomeUsuario { get; private set; }

        public string senhaUsuario { get; private set; }



        public Usuario(string nomeUsu, string senhaUsu)
        {
            if (nomeUsu != null)
            {
                nomeUsuario = nomeUsu;
                senhaUsuario = senhaUsu;
            }


        }
    }
}
