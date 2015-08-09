using Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace View
{
    public partial class PesquisaProduto : Form
    {
        public PesquisaProduto()
        {
            InitializeComponent();
        }
        ProdutoDAO produtoDao = new ProdutoDAO();

        private void PesquisaProduto_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar As Informações: " + Erro.Message, "Erro");
            }
        }

        private void CarregarGrid()
        {
            try
            {
                dgv_produto.DataSource = produtoDao.selectFullProdutoPorCodigoComEstoque();
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar As Informações: " + Erro.Message, "Erro");
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_produto.Text.Length > 1)
                {


                    if ((produtoDao.selectProdutoPorNome(txt_produto.Text, "Pes").Rows.Count == 0))
                    {
                        Message("Nenhum Produto Encontrado", "Aviso");
                        CarregarGrid();
                        LimparTxt();
                        FocoNoTxtProduto();
                        return;
                    }
                    if (produtoDao.selectProdutoPorNome(txt_produto.Text, "Pes") != null)
                    {
                        dgv_produto.DataSource = produtoDao.selectProdutoPorNome(txt_produto.Text, "Pes");
                    }
                    else
                    {
                        Message("Não Existe Produto Com Esse Nome: " + txt_produto.Text, "Aviso");
                        FocoNoTxtProduto();
                        CarregarGrid();
                    }
                }
                else
                {
                    Message("É Necessario Pesquisar Com Duas Letras Ou Mais", "Aviso");
                    LimparTxt();
                    FocoNoTxtProduto();
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar As Informações: " + Erro.Message, "Erro");
            }
        }

        private void LimparTxt()
        {
            txt_produto.Text = string.Empty;
        }

        private void FocoNoTxtProduto()
        {
            this.ActiveControl = txt_produto;
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txt_produto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_produto.Text.Length < 3)
                {
                    CarregarGrid();
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar As Informações: " + Erro.Message, "Erro");
            }

        }

        private void btnCarregarPorUnidade_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabela = produtoDao.selectFullProdutoPorCodigoComEstoque();
                dgv_produto.DataSource = tabela;
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar As Informações: " + Erro.Message, "Erro");
            }
        }

        private void btnCarregarPorPeso_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable tabela = produtoDao.selectFullProdutoPorPeso();
                dgv_produto.DataSource = tabela;
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar As Informações: " + Erro.Message, "Erro");
            }
        }

        private void txt_produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btn_Pesquisar_Click(sender, e);
            }
           
        }
    }
}
