namespace View
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.k_Menu = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Venda = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Pesquisa = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.SuspendLayout();
            // 
            // k_Menu
            // 
            this.k_Menu.AutoSize = false;
            this.k_Menu.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Venda,
            this.btn_Pesquisa});
            this.k_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.k_Menu.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.k_Menu.Location = new System.Drawing.Point(0, 0);
            this.k_Menu.Name = "k_Menu";
            this.k_Menu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.k_Menu.Size = new System.Drawing.Size(484, 41);
            this.k_Menu.StateCommon.ButtonEdgeInset = 1;
            this.k_Menu.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(20, 1, 1, 1);
            this.k_Menu.TabIndex = 4;
            this.k_Menu.Values.Description = "";
            this.k_Menu.Values.Heading = "Terminal";
            this.k_Menu.Values.Image = ((System.Drawing.Image)(resources.GetObject("k_Menu.Values.Image")));
            // 
            // btn_Venda
            // 
            this.btn_Venda.ExtraText = "Venda";
            this.btn_Venda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Venda.Image")));
            this.btn_Venda.UniqueName = "00073B9BCD2C4B8E0EA123472C2935C5";
            this.btn_Venda.Click += new System.EventHandler(this.btn_Venda_Click);
            // 
            // btn_Pesquisa
            // 
            this.btn_Pesquisa.ExtraText = "Produtos";
            this.btn_Pesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisa.Image")));
            this.btn_Pesquisa.UniqueName = "3AC40C5883F4439658B6960C7FF1DEA2";
            this.btn_Pesquisa.Click += new System.EventHandler(this.btn_Pesquisa_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 466);
            this.Controls.Add(this.k_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeader k_Menu;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Venda;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Pesquisa;
    }
}