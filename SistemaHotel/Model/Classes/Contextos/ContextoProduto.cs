using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Entidades;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace SistemaHotel.Model.Classes.Contextos
{
    internal class ContextoProduto : DbContext
    {
        //Propriedade
        public DbSet<Produto> produto { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string string_de_conexao = Environment.GetEnvironmentVariable("string_de_conexao")?.Trim('"');

            opcoesDeConstrucao.UseNpgsql(string_de_conexao);


        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Produto>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.Nome);
                entidade.Property(e => e.Descricao);
                entidade.Property(e => e.Estoque);
                entidade.Property(e => e.Fornecedor);
                entidade.Property(e => e.Valor);
            }
        );
        }   

    }
}

