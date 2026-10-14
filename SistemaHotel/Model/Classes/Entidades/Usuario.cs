

namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Usuario
    {

        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Usuarios { get; set; }
        public string Senha { get; set; }

        //Construtor
        public Usuario(string nome, string cargo, string usuarios, string senha)
        {
            Nome = nome;
            Cargo = cargo;
            Usuarios = usuarios;
            Senha = senha;
        }


    }
}
