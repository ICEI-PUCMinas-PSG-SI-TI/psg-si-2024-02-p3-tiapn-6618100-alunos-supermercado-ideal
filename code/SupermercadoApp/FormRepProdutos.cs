using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SupermercadoApp
{
    public partial class FormRepProdutos : Form
    {
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        // String de conexão com o banco de dados
        static string connectionString = "Server=sql10.freesqldatabase.com;Database=sql10751904;User=sql10751904;Password=twe9qfanwW;";

        public FormRepProdutos()
        {

            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(760, 400);
            this.dataGridViewProdutos.TabIndex = 0;

            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Name = "FormProdutos";
            this.Text = "Relatório de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            CarregarProdutos(); // Carrega os produtos ao abrir a tela
        }

        // Método para carregar os dados dos produtos
        private void CarregarProdutos()
        {
            try
            {
                // Query para buscar os dados dos produtos
                string query = "SELECT Nome, Descricao, Preco, Quant_Atual FROM Produto";

                // Criando a conexão com o banco de dados
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Adaptador para preencher o DataGridView
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Definindo a fonte de dados do DataGridView
                        dataGridViewProdutos.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os produtos: " + ex.Message);
            }
        }
    }
}