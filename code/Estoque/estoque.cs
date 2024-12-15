using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class estoque : Form
    {
        private List<Produto> _estoque = new List<Produto>();
        private int _nextId = 1;

        public estoque()
        {
            InitializeComponent();
            RenomearComponentes();
            AtualizarListaProdutos();
            btnAdicionar.Click += BtnAdicionar_Click;
        }

        private void RenomearComponentes()
        {
            txtNome = textBox1;
            txtCodigo = textBox2;
            txtQuantidade = textBox3;
            txtPreco = textBox4;
            dgvProdutos = dataGridView1;
            btnAdicionar = button1;
            btnRemover = button2;

            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.MultiSelect = false;
            dgvProdutos.AutoGenerateColumns = true; // Garante que as colunas sejam geradas automaticamente
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                !int.TryParse(txtQuantidade.Text, out int quantidade) ||
                !decimal.TryParse(txtPreco.Text, out decimal preco))
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente!");
                return;
            }

            var produto = new Produto
            {
                Id = _nextId++,
                Nome = txtNome.Text,
                Codigo = txtCodigo.Text,
                Quantidade = quantidade,
                Preco = preco
            };

            _estoque.Add(produto);
            MessageBox.Show("Produto adicionado com sucesso!");
            LimparCampos();
            AtualizarListaProdutos();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                try
                {
                    int rowIndex = dgvProdutos.SelectedRows[0].Index;
                    if (rowIndex >= 0 && rowIndex < _estoque.Count)
                    {
                        _estoque.RemoveAt(rowIndex);
                        MessageBox.Show("Produto removido com sucesso!");
                        AtualizarListaProdutos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao remover o produto: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover.");
            }
        }

        private void AtualizarListaProdutos()
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = _estoque;
            dgvProdutos.ClearSelection();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCodigo.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
        }

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvProdutos;
    }

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
