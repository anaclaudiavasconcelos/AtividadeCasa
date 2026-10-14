
using SistemaHotel.Model.Classes.Contextos;
using SistemaHotel.Model.Classes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Cadastros
{
    public partial class FrmUsuarios : Form
    {


        string id;

        string usuarioAntigo;

        public FrmUsuarios()
        {
            InitializeComponent();
        }


        private void CarregarCombobox()
        {
            var contexto = new ContextoCargo();
            cbCargo.DataSource = contexto.cargo.ToList();
            cbCargo.DisplayMember = "NomeDoCargo";
            cbCargo.ValueMember = "Id";

        }


        private void FormatarDG()
        {

        }

        private void Listar()
        {

            var contexto = new ContextoUsuario();
            grid.DataSource = contexto.usuario.ToList();

            FormatarDG();
        }





        private void BuscarNome()
        {
            ContextoUsuario contexto = new ContextoUsuario();
            var lista = contexto.usuario.ToList();
            if (txtBuscarNome.Text != "")
            {
                grid.DataSource = lista.Where(x => x.Nome.Contains(txtBuscarNome.Text)).ToList();
            }
            else
            {
                grid.DataSource = lista;
            }

            FormatarDG();
        }


        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            cbCargo.Enabled = true;
            
            txtNome.Focus();

        }


        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            cbCargo.Enabled = false;
        }


        private void limparCampos()
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            
        }




        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Listar();
            
            CarregarCombobox();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (cbCargo.Text == "")
            {
                MessageBox.Show("Cadastre Antes um Cargo!");
                Close();
            }

            habilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }








            //VERIFICAR SE O NOME DE USUÁRIO JÁ EXISTE NO BANCO
            ContextoUsuario contexto = new ContextoUsuario();
            var usuarioExistente = contexto.usuario.FirstOrDefault(x => x.Usuarios == txtUsuario.Text);

            if (usuarioExistente != null) // Aqui você deve colocar a lógica para verificar se o usuário já existe no banco de dados
            {
                MessageBox.Show("Usuário já Registrado!", "Erro ao Salva", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtUsuario.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO PARA SALVAR
            
            var usuario = new Usuario(txtNome.Text, cbCargo.Text, txtUsuario.Text, txtSenha.Text);
            contexto.usuario.Add(usuario);
            contexto.SaveChanges();

            grid.DataSource = contexto.usuario.Select(x => new
            {
                x.Id,
                x.Nome,
                x.Cargo,
                x.Usuarios,
                x.Senha
            }).ToList();
            grid.Columns[0].HeaderText = "Código";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "Cargo";
            grid.Columns[3].HeaderText = "Usuário";
            grid.Columns[4].HeaderText = "Senha";


            MessageBox.Show("Registro Salvo com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }








            //VERIFICAR SE O USUARIO JÁ EXISTE NO BANCO
            

            if (txtUsuario.Text != usuarioAntigo)
            {
                var contexto = new ContextoUsuario();

                var usuarioExistente = contexto.usuario.FirstOrDefault(x => x.Usuarios == txtUsuario.Text);

                if (usuarioExistente != null) // Aqui você deve colocar a lógica para verificar se o usuário já existe no banco de dados
                {
                    MessageBox.Show("Usuário já Registrado!", "Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = "";
                    txtUsuario.Focus();
                    return;
                }

                //CÓDIGO DO BOTÃO PARA EDITAR
                

                var usuario = contexto.usuario.FirstOrDefault(x => x.Id.ToString() == id);
                usuario.Nome = txtNome.Text;
                usuario.Usuarios = txtUsuario.Text;
                usuario.Cargo = cbCargo.Text;
                usuario.Senha = txtSenha.Text;
                contexto.SaveChanges();

            }



 

            MessageBox.Show("Registro Editado com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            habilitarCampos();

            id = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            cbCargo.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtUsuario.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtSenha.Text = grid.CurrentRow.Cells[4].Value.ToString();
            
            usuarioAntigo = grid.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja Realmente Excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //CÓDIGO DO BOTÃO PARA EXCLUIR
                var contexto = new ContextoUsuario();
                contexto.usuario.Remove(contexto.usuario.FirstOrDefault(x => x.Id.ToString() == id));
                contexto.SaveChanges();

                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                txtNome.Text = "";
                txtNome.Enabled = false;
                Listar();
            }
        }

        private void TxtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }
    }
}
