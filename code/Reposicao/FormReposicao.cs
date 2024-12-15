using MySql.Data.MySqlClient;
//using System.Data;
//using System.Data.SqlClient;

namespace SupermercadoApp;

public partial class FormReposicao : Form
{
    // String de conexão com o banco de dados
    static string connectionString = "Server=sql10.freesqldatabase.com;Database=sql10751904;User=sql10751904;Password=twe9qfanwW;";

    // Barra superior
    private Panel barraSuperior = null!;
    private PictureBox logoSupermercado = null!;
    private Label dataHoraLabel = null!;
    private Button perfilButton = null!;

    // Menu lateral esquerdo
    private Panel menuLateral = null!;
    private Button btnLogin = null!;
    private Button btnCaixa = null!;
    private Button btnEstoque = null!;
    private Button btnReposicao = null!;

    // Conteúdo principal
    private Panel conteudoPrincipal = null!;
    private Button btnTempoAnalise = null!;
    private Button btnSolicitarRelatorio = null!;
    private Button btnEmitirLista = null!;
    private Button btnEnviarLista = null!;
    //-------------TESTE
    private Button btnTeste = null!;
    
    private ListView listViewReposicao = null!;

    // Método para criar Barra Superior
    private void CriarBarraSuperior()
    {
        barraSuperior = new Panel
        {
            Size = new Size(this.Width, 60),
            Dock = DockStyle.Top,
            BackColor = Color.FromArgb(247,247,247)
        };
        this.Controls.Add(barraSuperior);

        // Logo
        logoSupermercado = new PictureBox
        {
            Image = Image.FromFile("./img/logo.png"),
            SizeMode = PictureBoxSizeMode.StretchImage,
            Location = new Point(10, 10),
            Size = new Size(120, 40)
        };
        barraSuperior.Controls.Add(logoSupermercado);

        // Data e Hora
        dataHoraLabel = new Label
        {
            Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
            AutoSize = true,
            Location = new Point(barraSuperior.Width / 2 - 60, 20)
        };
        barraSuperior.Controls.Add(dataHoraLabel);

        // Botão de Perfil
        perfilButton = new Button
        {
            Text = "👤 Usuário",
            Location = new Point(barraSuperior.Width - 60, 10),
            Size = new Size(60, 40),
            FlatStyle = FlatStyle.Flat
        };
        perfilButton.Click += (s, e) => MessageBox.Show("Perfil e Logoff");
        barraSuperior.Controls.Add(perfilButton);
    }
//-----------------------------------------------------------------------------------------------------------------------------------------
    // Método para criar Menu Lateral Esquerdo
    private void CriarMenuLateral()
    {
        menuLateral = new Panel
        {
            Size = new Size(150, (this.Height - 60)),
            Dock = DockStyle.Left,
            BackColor = Color.FromArgb(247,247,247)
        };
        this.Controls.Add(menuLateral);

        // Botões do menu
        btnLogin = CriarBotaoMenu("Login", 0);
        btnCaixa = CriarBotaoMenu("Caixa Eletrônico", 40);
        btnEstoque = CriarBotaoMenu("Estoque", 80);
        btnReposicao = CriarBotaoMenu("Reposição de Produtos", 120);

        menuLateral.Controls.AddRange(new Control[] { btnLogin, btnCaixa, btnEstoque, btnReposicao });
    }
    // Método auxiliar para criar os botões
    private Button CriarBotaoMenu(string texto, int top)
    {
        return new Button
        {
            Text = texto,
            Size = new Size(150, 40),
            Location = new Point(0, top),
            FlatStyle = FlatStyle.Flat,
            ForeColor = Color.Black,
            BackColor = Color.White
        };
    }

//-----------------------------------------------------------------------------------------------------------------------------------------
    // Método para criar Conteúdo Principal
    private void CriarConteudoPrincipal()
    {
        conteudoPrincipal = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = Color.White
        };
        this.Controls.Add(conteudoPrincipal);

        /*btnTempoAnalise = CriarBotaoConteudo("Tempo até próxima análise", 50);
        btnSolicitarRelatorio = CriarBotaoConteudo("Solicitar relatório", 100);
        btnEmitirLista = CriarBotaoConteudo("Emitir lista de compra", 150);
        btnEnviarLista = CriarBotaoConteudo("Enviar lista ao fornecedor", 200);*/
        btnSolicitarRelatorio = CriarBotaoConteudo("Solicitar relatório", 150);
        btnEmitirLista = CriarBotaoConteudo("Emitir lista de compra", 200);

        // Eventos Click
        btnSolicitarRelatorio.Click += new System.EventHandler(this.btnSolicitarRelatorio_Click);
        btnEmitirLista.Click += new System.EventHandler(this.btnEmitirLista_Click);
        
        //-------------TESTE
        btnTeste = CriarBotaoConteudo("Teste de conexão", 250);
        btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
        

        // ListView
        listViewReposicao = new ListView
        {
            Location = new Point(350, 50),
            Size = new Size(500, 300),
            View = View.Details
        };
        listViewReposicao.Columns.Add("Código", 80);
        listViewReposicao.Columns.Add("Nome", 150);
        listViewReposicao.Columns.Add("Qtd Máxima", 100);
        listViewReposicao.Columns.Add("Qtd Mínima", 100);
        listViewReposicao.FullRowSelect = true;
        CarregarDadosNoListView();

        // Adicionando controles ao conteúdo principal
        conteudoPrincipal.Controls.AddRange(new Control[]
        {
            //btnTempoAnalise, btnSolicitarRelatorio, btnEmitirLista, btnEnviarLista, btnTeste, listViewReposicao
            btnSolicitarRelatorio, btnEmitirLista, listViewReposicao
        });
    }
    // Método auxiliar para criar os botões
    private Button CriarBotaoConteudo(string texto, int top)
    {
        return new Button
        {
            Text = texto,
            Size = new Size(200, 40),
            Location = new Point(100, top),
            BackColor = BackColor = Color.FromArgb(247,247,247),
            FlatStyle = FlatStyle.Flat
        };
    }
    // Métodos dos Eventos Click
    private void btnSolicitarRelatorio_Click(object sender, EventArgs e)
    {
        FormRepProdutos formProdutos = new FormRepProdutos();
        formProdutos.ShowDialog();
    }

    private void btnEmitirLista_Click(object sender, EventArgs e)
    {
        FormRepListaCompra formListaCompra = new FormRepListaCompra();
        formListaCompra.ShowDialog();
    }

    private void CarregarDadosNoListView()
    {
        try
        {
            // Limpar o ListView
            listViewReposicao.Items.Clear();

            // Abrir conexão com o banco
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Query SQL para buscar ID e Nome de todos os produtos
                string query = "SELECT ID, Nome FROM Produto";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Criar uma nova linha (ListViewItem)
                        ListViewItem item = new ListViewItem(reader["ID"].ToString());
                        item.SubItems.Add(reader["Nome"].ToString());
                        item.SubItems.Add("1000");
                        item.SubItems.Add("51");

                        // Adicionar a linha ao ListView
                        listViewReposicao.Items.Add(item);
                    }
                }
                // Fechar a conexão
                conn.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
//-----------------------------------------------------------------------------------------------------------------------------------------
    private void btnTeste_Click(object sender, EventArgs e)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            // Testar se a conexão foi bem-sucedida
            if (conn.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Conexão ao banco de dados realizada com sucesso!");
            }else{
                MessageBox.Show("Erro para conectar!!!");
            }
            // Fechar a conexão
            conn.Close();
        }
    }

    public FormReposicao()
    {
        //this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1100, 600);
        this.Text = "Supermercado Ideal";
        
        
        CriarConteudoPrincipal();
        CriarMenuLateral();
        CriarBarraSuperior();
        
        
        
        //InitializeComponent();
    }

}
