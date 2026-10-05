

namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Usuario
    {

        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuarios { get; set; }
        public string Cargo { get; set; }
        public int Senha { get; set; }

        //Construtor
        public Usuario(string nome, string usuarios, string cargo, int senha)
        {
            Nome = nome;
            Usuarios = usuarios;
            Cargo = cargo;
            Senha = senha;
        }


    }
}
