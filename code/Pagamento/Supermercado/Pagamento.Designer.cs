namespace Supermercado
{
    partial class Pagamento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagamento));
            btnLogin = new Button();
            logo = new Button();
            btnCaixaEletronico = new Button();
            btnEstoque = new Button();
            btnReposicao = new Button();
            comboBoxFormaDePagamento = new ComboBox();
            lblValor = new Label();
            lblFormaDePagamento = new Label();
            listView1 = new ListView();
            button1 = new Button();
            btnFinalixa = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(0, 117);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(194, 49);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // logo
            // 
            logo.DialogResult = DialogResult.No;
            logo.Enabled = false;
            logo.Location = new Point(0, 1);
            logo.Name = "logo";
            logo.Size = new Size(194, 75);
            logo.TabIndex = 5;
            logo.Text = "Supermercado Ideal";
            logo.UseVisualStyleBackColor = true;
            // 
            // btnCaixaEletronico
            // 
            btnCaixaEletronico.Location = new Point(0, 164);
            btnCaixaEletronico.Name = "btnCaixaEletronico";
            btnCaixaEletronico.Size = new Size(194, 49);
            btnCaixaEletronico.TabIndex = 6;
            btnCaixaEletronico.Text = "Caixa Eletrônico";
            btnCaixaEletronico.UseVisualStyleBackColor = true;
            btnCaixaEletronico.Click += btnCaixaEletronico_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.Location = new Point(0, 211);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(194, 49);
            btnEstoque.TabIndex = 7;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // btnReposicao
            // 
            btnReposicao.Location = new Point(0, 259);
            btnReposicao.Name = "btnReposicao";
            btnReposicao.Size = new Size(194, 49);
            btnReposicao.TabIndex = 8;
            btnReposicao.Text = "reposicao";
            btnReposicao.UseVisualStyleBackColor = true;
            btnReposicao.Click += btnReposicao_Click;
            // 
            // comboBoxFormaDePagamento
            // 
            comboBoxFormaDePagamento.FormattingEnabled = true;
            comboBoxFormaDePagamento.Items.AddRange(new object[] { "Pix", "Dinheiro", "Crédito", "Débito" });
            comboBoxFormaDePagamento.Location = new Point(239, 164);
            comboBoxFormaDePagamento.Name = "comboBoxFormaDePagamento";
            comboBoxFormaDePagamento.Size = new Size(236, 28);
            comboBoxFormaDePagamento.TabIndex = 9;
            comboBoxFormaDePagamento.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.BackColor = SystemColors.Desktop;
            lblValor.BorderStyle = BorderStyle.FixedSingle;
            lblValor.ForeColor = Color.Snow;
            lblValor.Location = new Point(249, 28);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(215, 22);
            lblValor.TabIndex = 10;
            lblValor.Text = "Valor total a ser pago: R$XX,00";
            lblValor.Click += label1_Click;
            // 
            // lblFormaDePagamento
            // 
            lblFormaDePagamento.AutoSize = true;
            lblFormaDePagamento.BackColor = SystemColors.ControlLightLight;
            lblFormaDePagamento.BorderStyle = BorderStyle.FixedSingle;
            lblFormaDePagamento.ForeColor = Color.Black;
            lblFormaDePagamento.Location = new Point(239, 131);
            lblFormaDePagamento.Name = "lblFormaDePagamento";
            lblFormaDePagamento.Size = new Size(236, 22);
            lblFormaDePagamento.TabIndex = 11;
            lblFormaDePagamento.Text = "Selecione a forma de pagamento:";
            lblFormaDePagamento.Click += label1_Click_1;
            // 
            // listView1
            // 
            listView1.Location = new Point(531, 28);
            listView1.Name = "listView1";
            listView1.Size = new Size(256, 232);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(531, 264);
            button1.Name = "button1";
            button1.Size = new Size(130, 29);
            button1.TabIndex = 13;
            button1.Text = "Voltar ao Caixa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnFinalixa
            // 
            btnFinalixa.Location = new Point(657, 264);
            btnFinalixa.Name = "btnFinalixa";
            btnFinalixa.Size = new Size(130, 29);
            btnFinalixa.TabIndex = 14;
            btnFinalixa.Text = "Finalizar";
            btnFinalixa.UseVisualStyleBackColor = true;
            btnFinalixa.Click += button2_Click;
            // 
            // Pagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 305);
            Controls.Add(btnFinalixa);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(lblFormaDePagamento);
            Controls.Add(lblValor);
            Controls.Add(comboBoxFormaDePagamento);
            Controls.Add(btnReposicao);
            Controls.Add(btnEstoque);
            Controls.Add(btnCaixaEletronico);
            Controls.Add(logo);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pagamento";
            Text = "Pagamento";
            Load += Pagamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button logo;
        private Button btnCaixaEletronico;
        private Button btnEstoque;
        private Button btnReposicao;
        private ComboBox comboBoxFormaDePagamento;
        private Label lblValor;
        private Label lblFormaDePagamento;
        private ListView listView1;
        private Button button1;
        private Button btnFinalixa;
    }
}
