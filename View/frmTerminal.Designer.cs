namespace View
{
    partial class frmTerminal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTerminal));
            this.txt_AtivaComanda = new System.Windows.Forms.TextBox();
            this.pnl_Operacao = new System.Windows.Forms.Panel();
            this.btn_cancelarVenda = new System.Windows.Forms.Button();
            this.gpb_Produto = new System.Windows.Forms.GroupBox();
            this.lblQuantidade = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblValor = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CodigoOuIdProduto = new System.Windows.Forms.TextBox();
            this.lbl_TipoDeVenda = new System.Windows.Forms.Label();
            this.txtValorNaComanda = new System.Windows.Forms.TextBox();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.gpb_TipoDeVenda = new System.Windows.Forms.GroupBox();
            this.rdb_IdProduto = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdb_codigoProduto = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.gpb_DadosProduto = new System.Windows.Forms.GroupBox();
            this.ltb_Comanda = new System.Windows.Forms.ListBox();
            this.gpb_SelecionaComanda = new System.Windows.Forms.GroupBox();
            this.btn_Deletar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ckb_porPeso = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.pnl_Operacao.SuspendLayout();
            this.gpb_Produto.SuspendLayout();
            this.gpb_TipoDeVenda.SuspendLayout();
            this.gpb_DadosProduto.SuspendLayout();
            this.gpb_SelecionaComanda.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_AtivaComanda
            // 
            this.txt_AtivaComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AtivaComanda.Location = new System.Drawing.Point(14, 15);
            this.txt_AtivaComanda.MaxLength = 3;
            this.txt_AtivaComanda.Name = "txt_AtivaComanda";
            this.txt_AtivaComanda.Size = new System.Drawing.Size(232, 62);
            this.txt_AtivaComanda.TabIndex = 1;
            this.txt_AtivaComanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AtivaComanda_KeyPress);
            // 
            // pnl_Operacao
            // 
            this.pnl_Operacao.Controls.Add(this.btn_cancelarVenda);
            this.pnl_Operacao.Controls.Add(this.gpb_Produto);
            this.pnl_Operacao.Controls.Add(this.gpb_TipoDeVenda);
            this.pnl_Operacao.Location = new System.Drawing.Point(20, 242);
            this.pnl_Operacao.Name = "pnl_Operacao";
            this.pnl_Operacao.Size = new System.Drawing.Size(365, 347);
            this.pnl_Operacao.TabIndex = 8;
            // 
            // btn_cancelarVenda
            // 
            this.btn_cancelarVenda.BackColor = System.Drawing.Color.Red;
            this.btn_cancelarVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_cancelarVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_cancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarVenda.Location = new System.Drawing.Point(23, 297);
            this.btn_cancelarVenda.Name = "btn_cancelarVenda";
            this.btn_cancelarVenda.Size = new System.Drawing.Size(329, 40);
            this.btn_cancelarVenda.TabIndex = 10;
            this.btn_cancelarVenda.Text = "Selecionar Comanda";
            this.btn_cancelarVenda.UseVisualStyleBackColor = false;
            this.btn_cancelarVenda.Click += new System.EventHandler(this.btn_cancelarVenda_Click);
            // 
            // gpb_Produto
            // 
            this.gpb_Produto.Controls.Add(this.lblQuantidade);
            this.gpb_Produto.Controls.Add(this.lblValor);
            this.gpb_Produto.Controls.Add(this.txt_CodigoOuIdProduto);
            this.gpb_Produto.Controls.Add(this.lbl_TipoDeVenda);
            this.gpb_Produto.Controls.Add(this.txtValorNaComanda);
            this.gpb_Produto.Controls.Add(this.txt_Quantidade);
            this.gpb_Produto.Location = new System.Drawing.Point(16, 100);
            this.gpb_Produto.Name = "gpb_Produto";
            this.gpb_Produto.Size = new System.Drawing.Size(336, 191);
            this.gpb_Produto.TabIndex = 9;
            this.gpb_Produto.TabStop = false;
            this.gpb_Produto.Text = "Produto";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblQuantidade.Location = new System.Drawing.Point(5, 13);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.lblQuantidade.Size = new System.Drawing.Size(111, 34);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Values.Image = ((System.Drawing.Image)(resources.GetObject("lblQuantidade.Values.Image")));
            this.lblQuantidade.Values.Text = "Quantidade";
            // 
            // lblValor
            // 
            this.lblValor.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblValor.Location = new System.Drawing.Point(168, 12);
            this.lblValor.Name = "lblValor";
            this.lblValor.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.lblValor.Size = new System.Drawing.Size(145, 34);
            this.lblValor.TabIndex = 6;
            this.lblValor.Values.Image = ((System.Drawing.Image)(resources.GetObject("lblValor.Values.Image")));
            this.lblValor.Values.Text = "Valor Do Produto";
            // 
            // txt_CodigoOuIdProduto
            // 
            this.txt_CodigoOuIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoOuIdProduto.Location = new System.Drawing.Point(9, 134);
            this.txt_CodigoOuIdProduto.MaxLength = 20;
            this.txt_CodigoOuIdProduto.Name = "txt_CodigoOuIdProduto";
            this.txt_CodigoOuIdProduto.Size = new System.Drawing.Size(321, 49);
            this.txt_CodigoOuIdProduto.TabIndex = 5;
            this.txt_CodigoOuIdProduto.TextChanged += new System.EventHandler(this.txt_CodigoOuIdProduto_TextChanged);
            this.txt_CodigoOuIdProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoOuIdProduto_KeyPress);
            // 
            // lbl_TipoDeVenda
            // 
            this.lbl_TipoDeVenda.AutoSize = true;
            this.lbl_TipoDeVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoDeVenda.Location = new System.Drawing.Point(7, 116);
            this.lbl_TipoDeVenda.Name = "lbl_TipoDeVenda";
            this.lbl_TipoDeVenda.Size = new System.Drawing.Size(24, 16);
            this.lbl_TipoDeVenda.TabIndex = 1;
            this.lbl_TipoDeVenda.Text = "??";
            // 
            // txtValorNaComanda
            // 
            this.txtValorNaComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorNaComanda.Location = new System.Drawing.Point(170, 49);
            this.txtValorNaComanda.MaxLength = 6;
            this.txtValorNaComanda.Name = "txtValorNaComanda";
            this.txtValorNaComanda.Size = new System.Drawing.Size(163, 62);
            this.txtValorNaComanda.TabIndex = 4;
            this.txtValorNaComanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorNaComanda_KeyPress);
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantidade.Location = new System.Drawing.Point(11, 49);
            this.txt_Quantidade.MaxLength = 3;
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(115, 62);
            this.txt_Quantidade.TabIndex = 4;
            // 
            // gpb_TipoDeVenda
            // 
            this.gpb_TipoDeVenda.Controls.Add(this.rdb_IdProduto);
            this.gpb_TipoDeVenda.Controls.Add(this.rdb_codigoProduto);
            this.gpb_TipoDeVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_TipoDeVenda.ForeColor = System.Drawing.Color.Red;
            this.gpb_TipoDeVenda.Location = new System.Drawing.Point(14, 3);
            this.gpb_TipoDeVenda.Name = "gpb_TipoDeVenda";
            this.gpb_TipoDeVenda.Size = new System.Drawing.Size(336, 97);
            this.gpb_TipoDeVenda.TabIndex = 8;
            this.gpb_TipoDeVenda.TabStop = false;
            this.gpb_TipoDeVenda.Text = "Tipo De Venda";
            // 
            // rdb_IdProduto
            // 
            this.rdb_IdProduto.AutoSize = false;
            this.rdb_IdProduto.Location = new System.Drawing.Point(6, 55);
            this.rdb_IdProduto.Name = "rdb_IdProduto";
            this.rdb_IdProduto.Size = new System.Drawing.Size(326, 36);
            this.rdb_IdProduto.TabIndex = 3;
            this.rdb_IdProduto.Values.Image = ((System.Drawing.Image)(resources.GetObject("rdb_IdProduto.Values.Image")));
            this.rdb_IdProduto.Values.Text = "Sem Código De Barra";
            this.rdb_IdProduto.CheckedChanged += new System.EventHandler(this.rdb_IdProduto_CheckedChanged_1);
            this.rdb_IdProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdb_IdProduto_KeyPress);
            // 
            // rdb_codigoProduto
            // 
            this.rdb_codigoProduto.AutoSize = false;
            this.rdb_codigoProduto.Location = new System.Drawing.Point(7, 19);
            this.rdb_codigoProduto.Name = "rdb_codigoProduto";
            this.rdb_codigoProduto.Size = new System.Drawing.Size(323, 37);
            this.rdb_codigoProduto.TabIndex = 2;
            this.rdb_codigoProduto.Values.Image = ((System.Drawing.Image)(resources.GetObject("rdb_codigoProduto.Values.Image")));
            this.rdb_codigoProduto.Values.ImageTransparentColor = System.Drawing.Color.White;
            this.rdb_codigoProduto.Values.Text = "Com Código De Barra";
            this.rdb_codigoProduto.CheckedChanged += new System.EventHandler(this.rdb_codigoProduto_CheckedChanged_1);
            this.rdb_codigoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdb_codigoProduto_KeyPress);
            // 
            // gpb_DadosProduto
            // 
            this.gpb_DadosProduto.Controls.Add(this.ltb_Comanda);
            this.gpb_DadosProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_DadosProduto.ForeColor = System.Drawing.Color.Red;
            this.gpb_DadosProduto.Location = new System.Drawing.Point(3, 132);
            this.gpb_DadosProduto.Name = "gpb_DadosProduto";
            this.gpb_DadosProduto.Size = new System.Drawing.Size(402, 104);
            this.gpb_DadosProduto.TabIndex = 9;
            this.gpb_DadosProduto.TabStop = false;
            this.gpb_DadosProduto.Text = "Produtos";
            // 
            // ltb_Comanda
            // 
            this.ltb_Comanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ltb_Comanda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltb_Comanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltb_Comanda.FormattingEnabled = true;
            this.ltb_Comanda.Location = new System.Drawing.Point(9, 16);
            this.ltb_Comanda.Name = "ltb_Comanda";
            this.ltb_Comanda.Size = new System.Drawing.Size(386, 80);
            this.ltb_Comanda.TabIndex = 0;
            this.ltb_Comanda.TabStop = false;
            // 
            // gpb_SelecionaComanda
            // 
            this.gpb_SelecionaComanda.Controls.Add(this.btn_Deletar);
            this.gpb_SelecionaComanda.Controls.Add(this.txt_AtivaComanda);
            this.gpb_SelecionaComanda.Location = new System.Drawing.Point(20, 1);
            this.gpb_SelecionaComanda.Name = "gpb_SelecionaComanda";
            this.gpb_SelecionaComanda.Size = new System.Drawing.Size(365, 83);
            this.gpb_SelecionaComanda.TabIndex = 10;
            this.gpb_SelecionaComanda.TabStop = false;
            this.gpb_SelecionaComanda.Text = "Selecionar Comanda";
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.btn_Deletar.Location = new System.Drawing.Point(252, 16);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.btn_Deletar.Size = new System.Drawing.Size(100, 61);
            this.btn_Deletar.TabIndex = 1;
            this.btn_Deletar.TabStop = false;
            this.btn_Deletar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Deletar.Values.Image")));
            this.btn_Deletar.Values.Text = "Deletar Itens";
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ckb_porPeso
            // 
            this.ckb_porPeso.AutoSize = false;
            this.ckb_porPeso.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.ckb_porPeso.Location = new System.Drawing.Point(20, 84);
            this.ckb_porPeso.Name = "ckb_porPeso";
            this.ckb_porPeso.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.ckb_porPeso.Size = new System.Drawing.Size(365, 45);
            this.ckb_porPeso.TabIndex = 11;
            this.ckb_porPeso.TabStop = false;
            this.ckb_porPeso.Text = "Por Peso";
            this.ckb_porPeso.Values.Image = ((System.Drawing.Image)(resources.GetObject("ckb_porPeso.Values.Image")));
            this.ckb_porPeso.Values.Text = "Por Peso";
            this.ckb_porPeso.CheckedChanged += new System.EventHandler(this.ckb_porPeso_CheckedChanged);
            // 
            // frmTerminal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 601);
            this.Controls.Add(this.ckb_porPeso);
            this.Controls.Add(this.gpb_SelecionaComanda);
            this.Controls.Add(this.gpb_DadosProduto);
            this.Controls.Add(this.pnl_Operacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTerminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminal Interno De Venda";
            this.Load += new System.EventHandler(this.frmTerminal_Load);
            this.pnl_Operacao.ResumeLayout(false);
            this.gpb_Produto.ResumeLayout(false);
            this.gpb_Produto.PerformLayout();
            this.gpb_TipoDeVenda.ResumeLayout(false);
            this.gpb_DadosProduto.ResumeLayout(false);
            this.gpb_SelecionaComanda.ResumeLayout(false);
            this.gpb_SelecionaComanda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AtivaComanda;
        private System.Windows.Forms.Panel pnl_Operacao;
        private System.Windows.Forms.GroupBox gpb_Produto;
        private System.Windows.Forms.TextBox txt_CodigoOuIdProduto;
        private System.Windows.Forms.Label lbl_TipoDeVenda;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.GroupBox gpb_TipoDeVenda;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdb_IdProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdb_codigoProduto;
        private System.Windows.Forms.GroupBox gpb_DadosProduto;
        private System.Windows.Forms.ListBox ltb_Comanda;
        private System.Windows.Forms.GroupBox gpb_SelecionaComanda;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Deletar;
        private System.Windows.Forms.Button btn_cancelarVenda;
        private System.Windows.Forms.Timer timer1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox ckb_porPeso;
        private System.Windows.Forms.TextBox txtValorNaComanda;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblValor;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblQuantidade;

    }
}