namespace View
{
    partial class PesquisaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaProduto));
            this.k_panelCabecalho = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Minimize = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_Sair = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gpb_Categoria = new System.Windows.Forms.GroupBox();
            this.btnCarregarPorUnidade = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCarregarPorPeso = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.btn_Pesquisar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgv_produto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).BeginInit();
            this.k_panelCabecalho.Panel.SuspendLayout();
            this.k_panelCabecalho.SuspendLayout();
            this.gpb_Categoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // k_panelCabecalho
            // 
            this.k_panelCabecalho.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btn_Minimize,
            this.btn_Sair});
            this.k_panelCabecalho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.k_panelCabecalho.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelCustom1;
            this.k_panelCabecalho.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonAlternate;
            this.k_panelCabecalho.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.k_panelCabecalho.ImeMode = System.Windows.Forms.ImeMode.On;
            this.k_panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.k_panelCabecalho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.k_panelCabecalho.Name = "k_panelCabecalho";
            this.k_panelCabecalho.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            // 
            // k_panelCabecalho.Panel
            // 
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_Categoria);
            this.k_panelCabecalho.Panel.Tag = "";
            this.k_panelCabecalho.Size = new System.Drawing.Size(851, 364);
            this.k_panelCabecalho.TabIndex = 4;
            this.k_panelCabecalho.ValuesPrimary.Heading = "Sistema Para Padarias";
            this.k_panelCabecalho.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("k_panelCabecalho.ValuesPrimary.Image")));
            this.k_panelCabecalho.ValuesSecondary.Heading = "MJ - Desenvolvimento De Sistemas";
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader;
            this.btn_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.Image")));
            this.btn_Minimize.UniqueName = "F9DC7085F7C9466CD1805C31B418453C";
            // 
            // btn_Sair
            // 
            this.btn_Sair.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader;
            this.btn_Sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sair.Image")));
            this.btn_Sair.UniqueName = "B24EDB7BA17B41152E94D952E272EA35";
            // 
            // gpb_Categoria
            // 
            this.gpb_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.gpb_Categoria.Controls.Add(this.btnCarregarPorUnidade);
            this.gpb_Categoria.Controls.Add(this.btnCarregarPorPeso);
            this.gpb_Categoria.Controls.Add(this.label1);
            this.gpb_Categoria.Controls.Add(this.txt_produto);
            this.gpb_Categoria.Controls.Add(this.btn_Pesquisar);
            this.gpb_Categoria.Controls.Add(this.dgv_produto);
            this.gpb_Categoria.Location = new System.Drawing.Point(11, 3);
            this.gpb_Categoria.Name = "gpb_Categoria";
            this.gpb_Categoria.Size = new System.Drawing.Size(827, 304);
            this.gpb_Categoria.TabIndex = 3;
            this.gpb_Categoria.TabStop = false;
            this.gpb_Categoria.Text = "Categoria";
            // 
            // btnCarregarPorUnidade
            // 
            this.btnCarregarPorUnidade.Location = new System.Drawing.Point(9, 80);
            this.btnCarregarPorUnidade.Name = "btnCarregarPorUnidade";
            this.btnCarregarPorUnidade.Size = new System.Drawing.Size(181, 27);
            this.btnCarregarPorUnidade.TabIndex = 11;
            this.btnCarregarPorUnidade.TabStop = false;
            this.btnCarregarPorUnidade.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregarPorUnidade.Values.Image")));
            this.btnCarregarPorUnidade.Values.Text = "Carregar Por Unidade";
            this.btnCarregarPorUnidade.Click += new System.EventHandler(this.btnCarregarPorUnidade_Click);
            // 
            // btnCarregarPorPeso
            // 
            this.btnCarregarPorPeso.Location = new System.Drawing.Point(230, 80);
            this.btnCarregarPorPeso.Name = "btnCarregarPorPeso";
            this.btnCarregarPorPeso.Size = new System.Drawing.Size(172, 27);
            this.btnCarregarPorPeso.TabIndex = 12;
            this.btnCarregarPorPeso.TabStop = false;
            this.btnCarregarPorPeso.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregarPorPeso.Values.Image")));
            this.btnCarregarPorPeso.Values.Text = "Carregar Por peso";
            this.btnCarregarPorPeso.Click += new System.EventHandler(this.btnCarregarPorPeso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Do Produto";
            // 
            // txt_produto
            // 
            this.txt_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_produto.Location = new System.Drawing.Point(9, 36);
            this.txt_produto.MaxLength = 10;
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(251, 38);
            this.txt_produto.TabIndex = 0;
            this.txt_produto.TextChanged += new System.EventHandler(this.txt_produto_TextChanged);
            this.txt_produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_produto_KeyPress);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(266, 33);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(136, 41);
            this.btn_Pesquisar.TabIndex = 1;
            this.btn_Pesquisar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.Values.Image")));
            this.btn_Pesquisar.Values.Text = "Pesquisar";
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // dgv_produto
            // 
            this.dgv_produto.AllowUserToAddRows = false;
            this.dgv_produto.AllowUserToDeleteRows = false;
            this.dgv_produto.AllowUserToOrderColumns = true;
            this.dgv_produto.AllowUserToResizeColumns = false;
            this.dgv_produto.AllowUserToResizeRows = false;
            this.dgv_produto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_produto.Location = new System.Drawing.Point(6, 127);
            this.dgv_produto.MultiSelect = false;
            this.dgv_produto.Name = "dgv_produto";
            this.dgv_produto.ReadOnly = true;
            this.dgv_produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produto.Size = new System.Drawing.Size(815, 177);
            this.dgv_produto.TabIndex = 0;
            this.dgv_produto.TabStop = false;
            // 
            // PesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 364);
            this.Controls.Add(this.k_panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PesquisaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa De Produto";
            this.Load += new System.EventHandler(this.PesquisaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).EndInit();
            this.k_panelCabecalho.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).EndInit();
            this.k_panelCabecalho.ResumeLayout(false);
            this.gpb_Categoria.ResumeLayout(false);
            this.gpb_Categoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup k_panelCabecalho;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Minimize;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Sair;
        private System.Windows.Forms.GroupBox gpb_Categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_produto;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Pesquisar;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_produto;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCarregarPorUnidade;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCarregarPorPeso;
    }
}