using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Produto
    {

        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public string Fornecedor { get; set; }
        public decimal Valor { get; set; }

        //Construtor
        public Produto(string nome, string descricao, string fornecedor, decimal valor)
        {
            Nome = nome;
            Descricao = descricao;
            Fornecedor = fornecedor;
            Valor = valor;
        }



    }
}
