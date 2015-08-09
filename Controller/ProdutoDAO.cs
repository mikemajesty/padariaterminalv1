using Model;
using System;
using System.Data;

namespace Controller
{
    public class ProdutoDAO : Conection
    {
        public DataTable selectProdutoQuantidadePorIdDaComanda(int IdComanda)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@IdComanda", IdComanda);
               // DataRowCollection Linhas = null;

                return ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectVendaComandaAtivaPorId");

            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message); ;
            }
        }
        public DataTable selectFullProdutoPorPeso()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectFullProdutoSemParametroPorPeso");


            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        
        public DataTable selectFullProduto()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectProdutoFullComEstoque]");

            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public bool SelectProdutoPorId(Produto produto,string Peso)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Id", produto.IdProduto);
                AdicionaParametro("@Peso",Peso);
                if (ExecutaComando(CommandType.StoredProcedure, "_aspSelectProdutoPorId") != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message); ;
            }
        }
        public DataTable selectFullProdutoPorCodigoComEstoque()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectProdutoFullComEstoque]");

            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public DataTable selectProdutoPorNome(string Nome,string Peso)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Nome", Nome);
                AdicionaParametro("@Peso",Peso);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectProdutoPorNome]");
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public bool SelectProdutoPorCodigo(Produto produto,string Peso)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Codigo", produto.Codigo);
                AdicionaParametro("@Peso",Peso);
                if (ExecutaComando(CommandType.StoredProcedure, "_aspSelectProdutoPorCodigo") != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
    }
}

