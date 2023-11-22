using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Angelo_01
{
    internal class UtilClass
    {
        public UtilClass() { }

        public string LerString(string pergunta)
        {
            string leitura;

            while (true)
            {
                Console.Write(pergunta);
                leitura = Console.ReadLine();

                if (!string.IsNullOrEmpty(leitura))
                {
                    return leitura;
                }
                else
                {
                    Console.WriteLine("Entrada invalida!");
                }
            }
        }

        public int LerInt(string pergunta)
        {
            while (true)
            {
                Console.Write(pergunta);

                bool i = int.TryParse(Console.ReadLine(), out int idade);

                if (i)
                {
                    return idade;
                }
                else
                {
                    Console.WriteLine("Valor invalido!");
                }
            }
        }

        public DateTime LerData(string pergunta)
        {
            while (true)
            {
                Console.WriteLine($"{pergunta} > AAAA/MM/DD < :");
                DateTime data = DateTime.Parse(Console.ReadLine());

                if (data != null)
                {
                    return data;
                }
                else
                {
                    Console.WriteLine("Data no formato invalido!");
                    Console.WriteLine("EXEMPLO -> ano/mes/dia  -> 2023/11/21");
                }
            }
        }

        public string LerCPF(string mensagem)
        {
            Controller controller = new Controller();
            bool valida = false;

            while (true)
            {
                Console.Write(mensagem);
                string cpf = Console.ReadLine();

                if (!string.IsNullOrEmpty(cpf) && cpf.Count() == 11)
                {
                    valida = controller.TemCPFValido(cpf);
                }

                if (valida)
                {
                    return cpf;
                }
                else
                {
                    Console.WriteLine($" O CPF -> {cpf} é invalido");
                }
            }
        }




    }
}
