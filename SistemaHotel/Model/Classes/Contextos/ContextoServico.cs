using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHotel.Model.Classes.Contextos
{
    internal class ContextoServico : DbContext
    {
        //Propriedade
        public DbSet<Servico> servico { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ANACLAUDIA\SQLEXPRESS;Database=SistemaHotel;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Servico>(entidade =>
            {
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.NomeServico);

                entidade.Property(e => e.ValorServico);


            }

        );

        }
    }
}
