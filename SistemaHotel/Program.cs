using System;
using System.Windows.Forms;
using SistemaHotel.Model.Classes.Contextos;

namespace SistemaHotel
{
    static class Program
    {
        //DECLARAR AS VARIAVEIS GLOBAIS DO SISTEMA
        public static string nomeUsuario;
        public static string cargoUsuario;

        public static string chamadaProdutos;

        public static string nomeProduto;
        public static string estoqueProduto;
        public static string idProduto;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmMenu());
            Application.Run(new FrmLogin());

           // ContextoUsuario usuario = new ContextoUsuario();
           // usuario.Database.EnsureCreated();

           

        }
    }
}
