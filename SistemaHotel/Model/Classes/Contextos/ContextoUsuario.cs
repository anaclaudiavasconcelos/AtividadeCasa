using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Entidades;


namespace SistemaHotel.Model.Classes.Contextos
{
    internal class ContextoUsuario : DbContext
    {
        //Propriedade
        public DbSet<Usuario> usuario { get; set; }



        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ANACLAUDIA\SQLEXPRESS;Database=SistemaHotel;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Usuario>(entidade =>
            {
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.Nome);
                entidade.Property(e => e.Usuarios);
                entidade.Property(e => e.Cargo);
                entidade.Property(e => e.Senha);

            }

        );
        }

    }
}
