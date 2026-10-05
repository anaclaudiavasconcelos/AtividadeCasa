using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Entidades;

namespace SistemaHotel.Model.Classes.Contextos
{
    internal class ContextoFuncionario : DbContext
    {
        //Propriedade
        public DbSet<Funcionario> funcionario { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ANACLAUDIA\SQLEXPRESS;Database=SistemaHotel;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Funcionario>(entidade =>
            {
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.Nome);

                entidade.Property(e => e.Endereco);

                entidade.Property(e => e.Telefone);

                entidade.Property(e => e.Cpf);

                entidade.Property(e => e.Cargo);

            }

        );

        }
    }
}
