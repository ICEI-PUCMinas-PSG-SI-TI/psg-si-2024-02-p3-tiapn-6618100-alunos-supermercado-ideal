using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Supermercado_Windows_Form
{
        public partial class Caixa_Eletrônico : Form
        {
            public Caixa_Eletrônico()
            {
                InitializeComponent();
                InitializeClock();
        }

        private void CaixaEletrônico_Load(object sender, EventArgs e)
        {
            InitializeClock();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string codigoProduto = txtCodigoProduto.Text;
            int quantidade = (int)numericQuantidade.Value;

            if (string.IsNullOrEmpty(codigoProduto) || quantidade <= 0)
            {
                MessageBox.Show("Por favor, insira um código de produto e uma quantidade válida.");
                return;
            }

            try
            {
                MySqlConnection connection = DatabaseConnection.GetConnection();
                connection.Open();

                // Busca o produto no banco de dados
                string query = "SELECT Descricao, Preco FROM Produto WHERE Id = @codigoProduto";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigoProduto", codigoProduto);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string descricao = reader["Descricao"].ToString();
                    double preco = Convert.ToDouble(reader["Preco"]);

                    // Adiciona o produto à DataGridView
                    double subtotal = preco * quantidade;
                    dataGridViewProdutos.Rows.Add(descricao, preco, quantidade, subtotal);
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produto: " + ex.Message);
            }
        }

        private void InitializeClock()
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // Intervalo de 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            labelDataAtual.Text = DateTime.Now.ToShortDateString(); // Exibe data atual
            labelHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss"); // Exibe hora atual
            DateTime now = DateTime.Now;
            if (now.Hour >= 8 && now.Hour < 21)
            {
                label3.Text = "Aberto";
            }
            else
            {
                label3.Text = "Fechado";
            }
        }
        private void btnEstoque_Click(object sender, EventArgs e)
        {
        //    Form1 estoque = new Form1(); substituir pelo nome do formulário de estoque
        //    estoque.Show();
        }

        private void btnReposiçao_Click(object sender, EventArgs e)
        {
            //Form2 reposiçao = new Form2(); substituir pelo nome do formulário de reposiçao
            //reposiçao.Show();
        }
        private void btnPagamento_Click(object sender, EventArgs e)
        {
            //Form3 pagamento = new Form3(); substituir pelo nome do formulário de pagamento
            //pagamento.Show();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dataGridViewProdutos.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewProdutos_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelDataAtual_Click(object sender, EventArgs e)
        {

        }

        private void labelHoraAtual_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
