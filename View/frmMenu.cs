using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn_Venda_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmTerminal))
                    {
                        form.Activate();
                        return;
                    }
                }

                Form newForm = new frmTerminal();
                newForm.MdiParent = this;
                newForm.Show();
                //frmTerminal show = new frmTerminal();
                //show.MdiParent = this;
                //show.Show();
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Chamar A Janela: "+Erro.Message,"Erro");
            }
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Pesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(PesquisaProduto))
                    {
                        form.Activate();
                        return;
                    }
                }

                Form newForm = new PesquisaProduto();
                newForm.MdiParent = this;
                newForm.Show();

                //PesquisaProduto show = new PesquisaProduto();
                //show.MdiParent = this;
                //show.Show();
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Chamar A Janela: " + Erro.Message, "Erro");
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            try
            {
                
                int x = Screen.PrimaryScreen.Bounds.Size.Width;
                int y = Screen.PrimaryScreen.Bounds.Size.Height;
                this.Size = new System.Drawing.Size(x, y);
                this.Location = new System.Drawing.Point(0,0);
                 
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar Os Componentes: " + Erro.Message, "Erro");
            }
        }
    }
}
