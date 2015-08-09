using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmTerminal : Form
    {
        public frmTerminal()
        {
            InitializeComponent();
        }
        EstoqueDAO estoqueDAO = new EstoqueDAO();
        VendaDAO vendaDAo = new VendaDAO();
        ComandaDAO comandaDAo = new ComandaDAO();
        ProdutoDAO produtoDao = new ProdutoDAO();
        Produto produto = new Produto();

        private void rdb_codigoProduto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_IdProduto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmTerminal_Load(object sender, EventArgs e)
        {
            CarregaUmNoTxtQuantidade();
            DesaparecePanel();
            CheckRdbWithCode();
            FocoNaComanda();
            ColocarComoHideOListBox();
            txtValorNaComanda.Enabled = false;
            //DesapareceButton();
        }

        private void CheckRdbWithCode()
        {
            rdb_codigoProduto.Checked = true;
        }

        private void CarregaUmNoTxtQuantidade()
        {
            txt_Quantidade.Text = "1";
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_IncluirVendaNoCarrinho_Click(object sender, EventArgs e)
        {


        }

        private void txt_AtivaComanda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                LimparLtb();
                try
                {
                    Comanda comanda = new Comanda();
                    comanda.IdComanda = Convert.ToInt32(txt_AtivaComanda.Text);
                    if (comandaDAo.SelectComanda(comanda))
                    {

                        HabitarTxtIdComanda();



                        if (produtoDao.selectProdutoQuantidadePorIdDaComanda(comanda.IdComanda).Rows.Count > 0)
                        {

                            foreach (DataRow Linha in produtoDao.selectProdutoQuantidadePorIdDaComanda(comanda.IdComanda).Rows)
                            {
                                ApareceListBox();
                                if (Convert.ToInt32(Linha["QUANTIDADE"]) == 0)
                                {
                                    ltb_Comanda.Items.Add(string.Format("Nome: {0} - Venda Por Peso", Linha["NOME"].ToString()));

                                }
                                else
                                {
                                    ltb_Comanda.Items.Add(string.Format("Nome: {0} - Quantidade: {1}x", Linha["NOME"].ToString(), Convert.ToInt32(Linha["QUANTIDADE"])));

                                }

                            }


                        }

                        else
                        {

                            ColocarComoHideOListBox();

                            this.ActiveControl = txt_AtivaComanda;
                        }
                        AparecePanel();
                        DesabilitarTxtIdComanda();
                        FocoNoControle();
                    }
                    else
                    {
                        Message("Comanda Não Existe, Insira Um Valor Correspondente Ao ID Da Comanda", "Aviso");
                        LimparTxt();
                        FocoNaComanda();
                    }

                }
                catch (Exception Erro)
                {
                    Message("Erro Ao Selecionar A  Comanda: " + Erro.Message, "Erro");
                    LimparTxt();
                }
            }
        }

        private void ApareceListBox()
        {
            ltb_Comanda.Visible = true;
        }

        private void ColocarComoHideOListBox()
        {
            ltb_Comanda.Visible = false;
        }

        private void DesabilitarTxtIdComanda()
        {
            txt_AtivaComanda.Enabled = false;

        }
        private void HabitarTxtIdComanda()
        {
            txt_AtivaComanda.Enabled = true;

        }

        private void AparecePanel()
        {
            pnl_Operacao.Visible = true;
        }

        private void DesaparecePanel()
        {
            pnl_Operacao.Visible = false;
        }

        private void rdb_codigoProduto_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdb_codigoProduto.Checked)
            {
                if (ckb_porPeso.Checked)
                {
                    lbl_TipoDeVenda.Text = "Digite O Código De Barra Do Produto";
                    //ApareceButton();
                    this.ActiveControl = txtValorNaComanda;
                    txt_CodigoOuIdProduto.MaxLength = 15;
                    CleanTxtOfCodeAndId();
  
                }
                else
                {
                    lbl_TipoDeVenda.Text = "Digite O Código De Barra Do Produto";
                    //ApareceButton();
                    FocoNoControle();
                    txt_CodigoOuIdProduto.MaxLength = 15;
                    CleanTxtOfCodeAndId();
                }
                
            }
            else
            {
                lbl_TipoDeVenda.Text = "Digite O ID Do Produto";
                //ApareceButton();
                FocoNoControle();
                txt_CodigoOuIdProduto.MaxLength = 5;
                CleanTxtOfCodeAndId();
            }
        }

        private void CleanTxtOfCodeAndId()
        {
            txt_CodigoOuIdProduto.Text = string.Empty;
        }

        //private void ApareceButton()
        //{
        //    btn_IncluirVendaNoCarrinho.Visible = true;
        //}

        private void rdb_IdProduto_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdb_IdProduto.Checked)
            {
                if (ckb_porPeso.Checked)
                {
                    lbl_TipoDeVenda.Text = "Digite O ID Do Produto";
                    //ApareceButton();
                    this.ActiveControl = txtValorNaComanda;
                    txt_CodigoOuIdProduto.MaxLength = 5;
                    CleanTxtOfCodeAndId();
                }
                else
                {
                    lbl_TipoDeVenda.Text = "Digite O ID Do Produto";
                    //ApareceButton();
                    FocoNoControle();
                    txt_CodigoOuIdProduto.MaxLength = 5;
                    CleanTxtOfCodeAndId();
                }
                
            }
            else
            {
                lbl_TipoDeVenda.Text = "Digite O Código De Barra Do Produto";
                //ApareceButton();
                FocoNoControle();
                txt_CodigoOuIdProduto.MaxLength = 15;
                CleanTxtOfCodeAndId();
            }
        }

        private void FocoNoControle()
        {
            this.ActiveControl = txt_CodigoOuIdProduto;
        }

        private void btn_IncluirVendaNoCarrinho_Click_1(object sender, EventArgs e)
        {

        }

        private void FocoNaComanda()
        {
            this.ActiveControl = txt_AtivaComanda;
        }

        private void TirarFocoDosRDB()
        {
            rdb_codigoProduto.Checked = false;
            rdb_IdProduto.Checked = false;
        }

        //private void DesapareceButton()
        //{
        //    btn_IncluirVendaNoCarrinho.Visible = false;
        //}

        private void LimparTxt()
        {
            txt_AtivaComanda.Text = string.Empty;
            txt_CodigoOuIdProduto.Text = string.Empty;
        }

        private void rdb_codigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                rdb_codigoProduto.Checked = true;
            }
            txt_CodigoOuIdProduto.MaxLength = 5;
        }

        private void rdb_IdProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                rdb_IdProduto.Checked = true;
            }
        }

        private void txt_CodigoOuIdProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                try
                {
                    if (rdb_IdProduto.Checked)
                    {
                        VendeProdutoPorId();
                    }
                    else if (rdb_codigoProduto.Checked)
                    {
                        VendeProdutoPorCodigo();

                    }
                    else
                    {
                        Message("Antes De Inserir O Identificador Do Produto Escolha Que Tipo Do Mesmo Você Ira Usar [Com Código De Barra/Sem Código De Barra]", "Aviso");
                    }
                    CarregaUmNoTxtQuantidade();
                }
                catch (Exception Erro)
                {

                    Message("Erro Ao Concluir A Venda: " + Erro.Message, "Erro");
                    CleanTxtOfCodeAndId();
                }
            }
        }

        private void VendeProdutoPorCodigo()
        {
            try
            {
                produto.Codigo = txt_CodigoOuIdProduto.Text;

                if (ckb_porPeso.Checked == false)
                {
                    if (produtoDao.SelectProdutoPorCodigo(produto, "Nao"))
                    {
                        //DialogResult dialog = MessageBox.Show("Deseja Adicionar Esse Produto Na Comanda?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        //if (dialog == System.Windows.Forms.DialogResult.Yes)
                        //{

                        Comanda comanda = new Comanda();
                        comanda.IdComanda = Convert.ToInt32(txt_AtivaComanda.Text);
                        comanda.CodigoProduto = txt_CodigoOuIdProduto.Text;
                        comanda.Quantidade = Convert.ToInt32(txt_Quantidade.Text);

                        if (vendaDAo.SelectProdutoPorCodigo(comanda))
                        {
                            HabitarTxtIdComanda();
                            if (estoqueDAO.updateEstoqueComCodigo(comanda))
                            {
                                VerificaSeExisteNegativo();
                              /*  timer1.Start();
                                MessageBox.Show("Produto Inserido Com Sucesso", "Aviso", MessageBoxButtons.OK);
                                //SendKeys.Send("{OK}");
                                //SendKeys.Send("{Yes}");
                                LimparTxt();
                                //TirarFocoDosRDB();
                                //DesapareceButton();
                                LimparLtb();
                                DesaparecePanel();
                                ColocarComoHideOListBox();
                                FocoNaComanda();
                                DesmarcaCheckboxPesoLimpaValor();*/

                            }
                            else
                            {
                                Message("Venda Concluida, Mas Não Foi Dado Baixa No Estoque, Verifique A Quantidade Do Estoque E Atualize Para Evitar Esse Tipo De Erro", "Aviso");
                                // TirarFocoDosRDB();
                                //DesapareceButton();
                                DesaparecePanel();
                                FocoNaComanda();
                                ColocaUmNoTxt();
                                LimparLtb();
                                HabitarTxtIdComanda();
                                DesmarcaCheckboxPesoLimpaValor();
                            }
                        }
                        ////}
                        ////else
                        ////{
                        ////    LimparTxt();
                        ////    DesaparecePanel();
                        ////    HabitarTxtIdComanda();
                        ////    LimparLtb();
                        ////    FocoNaComanda();
                        ////    return;

                        ////}

                        /////////////

                    }
                    else
                    {
                        Message("Codigo Do Produto Não Existe, Digite Um ID Valído", "Aviso");
                        CleanTxtOfCodeAndId();
                        DesmarcaCheckboxPesoLimpaValor();
                        /*
                        Message("ID Inexistente ou ID Não Corresponde A Uma Venda Por Peso!","Aviso");
                        txt_CodigoOuIdProduto.Text = string.Empty;
                        /*                       
                        DesaparecePanel();
                        HabitarTxtIdComanda();
                        LimparLtb();                        
                        DesmarcaCheckboxPesoLimpaValor();
                        FocoNaComanda();*/
                        FocoNaComanda();
                        return;

                    }
                }
                else if (ckb_porPeso.Checked)
                {

                    produto.Codigo = txt_CodigoOuIdProduto.Text;

                    if (produtoDao.SelectProdutoPorCodigo(produto, "Sim"))
                    {
                        if (txtValorNaComanda.Text.Length > 0)
                        {


                            HabitarTxtIdComanda();
                            Comanda comanda = new Comanda();
                            comanda.IdComanda = Convert.ToInt32(txt_AtivaComanda.Text);
                            comanda.CodigoProduto = txt_CodigoOuIdProduto.Text;
                            comanda.PrecoVenda = Convert.ToDouble(txtValorNaComanda.Text);
                            //LimparLtb();
                            ComandaDAO comandaDAO = new ComandaDAO();
                            if (comandaDAO.insertComandaPorPesoComCodigo(comanda))
                            {
                                //VerificaSeExisteNegativo();
                                LimparTxt();
                                timer1.Start();
                                MessageBox.Show("Produto Inserido Com Sucesso", "Aviso", MessageBoxButtons.OK);
                                //TirarFocoDosRDB();
                                //DesapareceButton();
                                DesaparecePanel();
                                FocoNaComanda();
                                ColocarComoHideOListBox();
                                LimparLtb();
                                DesmarcaCheckboxPesoLimpaValor();
                                FocoNaComanda();
                            }
                            else
                            {
                                // Message("Produto Inserido Com Sucesso", "Aviso");
                                timer1.Start();
                                MessageBox.Show("Produto Inserido Com Sucesso", "Aviso", MessageBoxButtons.OK);
                                //TirarFocoDosRDB();
                                LimparTxt();
                                //DesapareceButton();
                                LimparLtb();
                                DesaparecePanel();
                                FocoNaComanda();
                                //  ColocaUmNoTxt();
                                //LimparLtb();
                                DesmarcaCheckboxPesoLimpaValor();
                                FocoNaComanda();
                            }

                        }
                        else
                        {
                            Message("Campo Valor Obrigatorio", "Aviso");
                            this.ActiveControl = txtValorNaComanda;
                        }

                    }
                    else
                    {
                        Message("Código Inexistente ou Código Não Corresponde A Um Registro!", "Aviso");
                        CleanTxtOfCodeAndId();
                        DesmarcaCheckboxPesoLimpaValor();
                        /* LimparTxt();
                        DesaparecePanel();
                        HabitarTxtIdComanda();
                        ColocarComoHideOListBox();
                        LimparLtb();
                        DesmarcaCheckboxPesoLimpaValor();
                        FocoNaComanda();*/
                        return;
                    }
                }
                else
                {
                    LimparTxt();
                    DesaparecePanel();
                    HabitarTxtIdComanda();
                    //LimparLtb();
                    FocoNaComanda();
                    DesmarcaCheckboxPesoLimpaValor();
                    return;

                }


                CarregaUmNoTxtQuantidade();

            }
            catch (Exception e)
            {

                Message("Não É Possível Ao inserir o produto na comanda: " + e.Message, "Aviso");
                DesmarcaCheckboxPesoLimpaValor();
            }
        }

        private void LimpaTxtDeCodigo()
        {
            throw new NotImplementedException();
        }

        private void LimpaTxtDeCod()
        {
            txt_CodigoOuIdProduto.Text = string.Empty;
        }

        private void VendeProdutoPorId()
        {
            try
            {
                produto.IdProduto = Convert.ToInt32(txt_CodigoOuIdProduto.Text);


                //DialogResult dialog = MessageBox.Show("Deseja Adicionar Esse Produto Na Comanda?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //if (dialog == System.Windows.Forms.DialogResult.Yes)
                //{
                if (ckb_porPeso.Checked == false)
                {

                    if (produtoDao.SelectProdutoPorId(produto, "Nao"))//produtoDao.SelectProdutoPorId(produto, "Pes")
                    {
                        HabitarTxtIdComanda();
                        Comanda comanda = new Comanda();
                        comanda.IdComanda = Convert.ToInt32(txt_AtivaComanda.Text);
                        comanda.IdProduto = Convert.ToInt32(txt_CodigoOuIdProduto.Text);
                        comanda.Quantidade = Convert.ToInt32(txt_Quantidade.Text);

                        if (vendaDAo.SelectProdutoPorID(comanda))
                        {
                            //DesapareceButton();
                            // TirarFocoDosRDB();
                            if (estoqueDAO.updateEstoqueComId(comanda))
                            {
                                LimparLtb();
                                VerificaSeExisteNegativo();

                                //}
                                //else
                                //{
                                //    Message("Venda Concluida, Mas Não Foi Dado Baixa No Estoque, Verifique A Quantidade Do Estoque E Atualize Para Evitar Esse Tipo De Erro", "Aviso");
                                //    // TirarFocoDosRDB();
                                //    //DesapareceButton();
                                //    DesaparecePanel();
                                //    LimparTxt();
                                //    FocoNaComanda();
                                //    ColocaUmNoTxt();

                                //}
                            }
                            else
                            {
                                Message("Produto Não Foi Inserido Na Comanda, Provavelmente O Código Ou ID Esta Incorreto", "Aviso");
                                DesmarcaCheckboxPesoLimpaValor();
                                FocoNoControle();
                            }

                        }

                    }
                    else
                    {
                        Message("ID Inexistente ou ID Não Corresponde A Um Registro!", "Aviso");
                        CleanTxtOfCodeAndId();
                        DesmarcaCheckboxPesoLimpaValor();
                        /*LimparTxt();
                        DesaparecePanel();
                        HabitarTxtIdComanda();
                        ColocarComoHideOListBox();
                        LimparLtb();
                        DesmarcaCheckboxPesoLimpaValor();*/
                        //FocoNaComanda();
                        FocoNaComanda();
                        return;
                    }
                }
                else if (ckb_porPeso.Checked)
                {

                    produto.IdProduto = Convert.ToInt32(txt_CodigoOuIdProduto.Text);

                    if (produtoDao.SelectProdutoPorId(produto, "Sim"))
                    {

                        if (txtValorNaComanda.Text.Length > 0)
                        {
                            HabitarTxtIdComanda();
                            Comanda comanda = new Comanda();
                            comanda.IdComanda = Convert.ToInt32(txt_AtivaComanda.Text);
                            comanda.IdProduto = Convert.ToInt32(txt_CodigoOuIdProduto.Text);
                            comanda.PrecoVenda = Convert.ToDouble(txtValorNaComanda.Text);
                            LimparLtb();
                            ComandaDAO comandaDAO = new ComandaDAO();
                            if (comandaDAO.insertComandaPorPesoComId(comanda))
                            {

                                LimparTxt();
                                timer1.Start();
                                MessageBox.Show("Produto Inserido Com Sucesso", "Aviso", MessageBoxButtons.OK);
                                //TirarFocoDosRDB();
                                //DesapareceButton();
                                DesaparecePanel();
                                LimparLtb();
                                FocoNaComanda();
                                ColocaUmNoTxt();
                                DesmarcaCheckboxPesoLimpaValor();
                                FocoNaComanda();
                                ColocarComoHideOListBox();
                            }
                            else
                            {
                                // Message("Produto Inserido Com Sucesso", "Aviso");
                                timer1.Start();
                                MessageBox.Show("Produto Inserido Com Sucesso", "Aviso", MessageBoxButtons.OK);
                                //TirarFocoDosRDB();
                                LimparTxt();
                                //DesapareceButton();
                                DesaparecePanel();
                                FocoNaComanda();
                                ColocaUmNoTxt();
                                LimparLtb();
                                DesmarcaCheckboxPesoLimpaValor();
                                FocoNaComanda();
                                ColocarComoHideOListBox();
                            }



                        }
                        else
                        {
                            Message("Campo Valor Obrigatorio", "Aviso");
                            this.ActiveControl = txtValorNaComanda;
                        }
                    }
                    else
                    {
                        Message("ID Inexistente ou ID Não Corresponde A Um Registro!", "Aviso");
                        CleanTxtOfCodeAndId();
                        DesmarcaCheckboxPesoLimpaValor();
                       // LimparTxt();
                        /*
                        DesaparecePanel();
                        HabitarTxtIdComanda();
                        ColocarComoHideOListBox();
                        LimparLtb();
                        DesmarcaCheckboxPesoLimpaValor();*/
                        FocoNaComanda();
                        return;
                    }
                }

                //  }
                // else
                //{
                //    Message("ID Do Produto Não Existe, Digite Um ID Valído", "Aviso");
                //      CleanTxtOfCodeAndId();
                //      DesmarcaCheckboxPesoLimpaValor();
                // }
                CarregaUmNoTxtQuantidade();
            }
            catch (Exception e)
            {

                Message("Não É Possível Ao inserir o produto na comanda: " + e.Message, "Aviso");
                DesmarcaCheckboxPesoLimpaValor();
            }

        }

        private void VerificaSeExisteNegativo()
        {
            if (estoqueDAO.SelectEstoqueNegativo().Rows.Count > 0)
            {
                string ValorNomeNegativo = estoqueDAO.SelectEstoqueNegativo().Rows[0]["Nome"].ToString();
                string ValorQuantidadeNegativo = estoqueDAO.SelectEstoqueNegativo().Rows[0]["Quantidade"].ToString();
                string full = string.Format("| Nome: {0} - Quantidade {1} |", ValorNomeNegativo, ValorQuantidadeNegativo);
                Message("A Venda Foi Salva Com Sucesso, Mas Existem Produtos Com Valores Negativos No Estoque: " + full + " Para Evitar Esse Tipo De Erro É Necessario Dar Entrada No Estoque Corretamente, Avise Um Funcionario Para Verificar A Quantidade Correta E Atualizar Para Evitar Esse Tipo De Erro", "Aviso");
                LimparTxt();
                //TirarFocoDosRDB();
                //DesapareceButton();
                DesaparecePanel();
                DesmarcaCheckboxPesoLimpaValor();
                FocoNaComanda();
            }
            else
            {
                // Message("Produto Inserido Com Sucesso", "Aviso");
                timer1.Start();
                MessageBox.Show("Produto Inserido Com Sucesso", "Aviso", MessageBoxButtons.OK);
                //TirarFocoDosRDB();
                LimparTxt();
                //DesapareceButton();
                DesaparecePanel();
                ColocaUmNoTxt();
                LimparLtb();
                DesmarcaCheckboxPesoLimpaValor();
                FocoNaComanda();
            }
        }

        private void DesmarcaCheckboxPesoLimpaValor()
        {
            if (ckb_porPeso.Checked)
            {
                ckb_porPeso.Checked = false;
            }
            txtValorNaComanda.Text = string.Empty;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");

            timer1.Stop();
        }

        //public void MessegeTimer()
        //{
        //    //SendKeys.Send("{ENTER}");
        //    //using ()
        //    //{

        //    //}
        //    MessageBox.Show("Produto Inserido Com Sucesso", "Aviso",MessageBoxButtons.OK);
        //    Thread.Sleep(TimeSpan.FromSeconds(1));
        //    SendKeys.SendWait("{~}");


        //}
        private void LimparLtb()
        {
            ltb_Comanda.Items.Clear();
        }

        private void ColocaUmNoTxt()
        {
            txt_Quantidade.Text = "1";
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dialog = MessageBox.Show("Deseja Excluir Os Itens Dessa Comanda?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == System.Windows.Forms.DialogResult.Yes)
                {

                    if (txt_AtivaComanda.Text.Length > 0 && txt_AtivaComanda.Enabled == false)
                    {
                        Comanda comanda = new Comanda();
                        comanda.IdComanda = Convert.ToInt32(txt_AtivaComanda.Text);
                        if (produtoDao.selectProdutoQuantidadePorIdDaComanda(comanda.IdComanda).Rows.Count > 0)
                        {
                            if (comandaDAo.SelectComanda(comanda))
                            {

                                if (comandaDAo.DeletePorId(comanda.IdComanda))
                                {
                                    Message("A Lista Esta Vazia", "Aviso");
                                    LimparLtb();
                                    LimparTxt();
                                    FocoNaComanda();
                                    DesaparecePanel();
                                    HabitarTxtIdComanda();
                                    FocoNaComanda();
                                }
                                else
                                {
                                    Message("Não Foi Possível Deletar Os Itens Da Comanda Ou Inexistente, Tente Novamente", "Aviso");
                                    LimparLtb();
                                    LimparTxt();
                                    FocoNaComanda();
                                }
                            }
                        }
                        else
                        {
                            Message("Não É Possível Excluir Itens De Uma Comanda Vazia", "Aviso");
                            FocoNaComanda();
                            //LimparTxt();
                        }
                    }
                    else
                    {
                        Message("Para Excluir Itens De Uma Comanda É Necessario Um Valor Valido E Uma Comanda Selecionada", "Aviso");
                        LimparLtb();
                        LimparTxt();
                        FocoNaComanda();
                    }

                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Tentar Excluir Os Itens Da Comanda: " + Erro.Message, "Erro");
            }
        }

        private void btn_cancelarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                LimparTxt();
                DesaparecePanel();
                HabitarTxtIdComanda();
                LimparLtb();
                DesmarcaCheckboxPesoLimpaValor();
                ColocarComoHideOListBox();
                FocoNaComanda();
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Tentar Cancelar A Venda A Venda: " + Erro.Message, "Erro");
                DesmarcaCheckboxPesoLimpaValor();
            }
        }

        private void txt_CodigoOuIdProduto_TextChanged(object sender, EventArgs e)
        {
            if (rdb_IdProduto.Checked)
            {
                txt_CodigoOuIdProduto.MaxLength = 5;
            }
            else if (rdb_codigoProduto.Checked)
            {
                txt_CodigoOuIdProduto.MaxLength = 15;
            }
            else
            {
                txt_CodigoOuIdProduto.MaxLength = 0;
            }
        }

        private void txtValorNaComanda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void ckb_porPeso_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // if (txt_AtivaComanda.Enabled == true)
                // {


                if (ckb_porPeso.Checked)
                {
                    txt_Quantidade.Enabled = false;
                    txtValorNaComanda.Enabled = true;
                    LimparTxtDeValor();
                    FocoNotxtDePreco();

                }
                else
                {
                    txtValorNaComanda.Enabled = false;
                    txt_Quantidade.Enabled = true;
                    LimparTxtDeValor();
                    FocoNoNumroDoIdOuCodigo();
                }
                // }
                // else
                // {
                //    ckb_porPeso.Checked = false;
                //     FocoNaComanda();
                // }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Tentar Checar O Botão: " + Erro.Message, "Erro");

            }
        }



        private void FocoNotxtDePreco()
        {
            this.ActiveControl = txtValorNaComanda;
        }

        private void FocoNoNumroDoIdOuCodigo()
        {
            this.ActiveControl = txt_CodigoOuIdProduto;
        }
        private void LimparTxtDeValor()
        {
            txtValorNaComanda.Text = string.Empty;
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    Message("Produto Inserido Com Sucesso", "Aviso");

        //}


    }
}
