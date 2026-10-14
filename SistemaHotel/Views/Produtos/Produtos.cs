
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

namespace SistemaHotel.Produtos
{
    public partial class FrmProdutos : Form
    {


        string id;

        public FrmProdutos()
        {
            InitializeComponent();
        }


        private void CarregarCombobox()
        {
            var contexto = new ContextoFornecedor();
            cbFornecedor.DataSource = contexto.fornecedor.ToList();
            cbFornecedor.DisplayMember = "Nome";
            cbFornecedor.ValueMember = "Id";


        }


        private void FormatarDG()
        {

        }

        private void Listar()
        {



            FormatarDG();
        }


        private void BuscarNome()
        {
            ContextoProduto contexto = new ContextoProduto();
            var lista = contexto.produto.ToList();
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
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            cbFornecedor.Enabled = true;
            //txtEstoque.Enabled = true;
            btnImg.Enabled = true;
            txtNome.Focus();

        }


        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            cbFornecedor.Enabled = false;
            txtEstoque.Enabled = false;
            btnImg.Enabled = false;
        }


        private void limparCampos()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
            txtEstoque.Text = "";
            LimparFoto();
        }



        private void LimparFoto()
        {
            img.Image = Properties.Resources.sem_foto;
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            LimparFoto();
            CarregarCombobox();
            Listar();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {


            if (cbFornecedor.Text == "")
            {
                MessageBox.Show("Cadastre Antes um Fornecedor!");
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

            if (txtValor.Text == "")
            {
                MessageBox.Show("Preencha o Valor", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Focus();
                return;
            }


            //CÓDIGO DO BOTÃO PARA SALVAR
            ContextoProduto contexto = new ContextoProduto();
            var produto = new Produto(txtNome.Text, txtDescricao.Text, cbFornecedor.Text, Convert.ToDecimal(txtValor.Text));
            contexto.produto.Add(produto);
            contexto.SaveChanges();

            grid.DataSource = contexto.produto.Select(x => new
            {
                x.Id,
                x.Nome,
                x.Descricao,
                x.Estoque,
                x.Fornecedor,
                x.Valor

            }).ToList();
            grid.Columns[0].HeaderText = "Código";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "Descrição";
            grid.Columns[3].HeaderText = "Estoque";
            grid.Columns[4].HeaderText = "Fornecedor";
            grid.Columns[5].HeaderText = "Valor";


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

            if (txtValor.Text == "")
            {
                MessageBox.Show("Preencha o Valor", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO PARA EDITAR
            var contexto = new ContextoProduto();

            var produto = contexto.produto.FirstOrDefault(x => x.Id.ToString() == id);
            produto.Nome = txtNome.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Estoque = Convert.ToInt32(txtEstoque.Text);
            produto.Fornecedor = cbFornecedor.Text;
            produto.Valor = Convert.ToDecimal(txtValor.Text);

            contexto.SaveChanges();


            MessageBox.Show("Registro Editado com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja Realmente Excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //CÓDIGO DO BOTÃO PARA EXCLUIR
                var contexto = new ContextoProduto();
                contexto.produto.Remove(contexto.produto.FirstOrDefault(x => x.Id.ToString() == id));
                contexto.SaveChanges();


                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                limparCampos();
                desabilitarCampos();
                Listar();
            }
        }

        private void BtnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg;*.png)|*.jpg;*.png|Todos os Arquivos(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                img.ImageLocation = foto;
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            habilitarCampos();

            id = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtEstoque.Text = grid.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txtValor.Text = grid.CurrentRow.Cells[5].Value.ToString();
        }

        private void TxtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.chamadaProdutos == "estoque")
            {
                Program.nomeProduto = grid.CurrentRow.Cells[1].Value.ToString();
                Program.estoqueProduto = grid.CurrentRow.Cells[3].Value.ToString();
                Program.idProduto = grid.CurrentRow.Cells[0].Value.ToString();
                Close();
            }
        }
    }
}
