﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Angelo_01
{
    internal class Empresa : Pessoa
    {
        public string CNPJ {  get; private set; }

        public Empresa() { }

        public Empresa(int codigo, string nome, string cnpj, string endereco, string telefone) 
        {
            Codigo = codigo;
            Nome = nome;
            this.CNPJ = cnpj;
            Endereco = endereco;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return $"\n____________________________" +
                   $"\n Codigo: {Codigo}" +
                   $"\n Nome: {Nome}" +
                   $"\n CNPJ: {this.CNPJ}" +
                   $"\n Telefone: {this.Telefone}" +
                   $"\n Endereço: {this.Endereco}" +
                   $"\n____________________________";
        }

        public string ToFileEmpresa()
        {
            return $"{Codigo},{Nome},{CNPJ},{Telefone},{Endereco}";
        }

    }
}