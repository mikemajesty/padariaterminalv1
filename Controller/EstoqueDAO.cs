using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class EstoqueDAO:Conection
    {
        public DataTable SelectEstoqueNegativo()
        {
            try
            {

                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectValoresNegativosNoEstoque]");
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public bool updateEstoqueComCodigo(Comanda estoque)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Codigo", estoque.CodigoProduto);
                AdicionaParametro("@Quantidade", estoque.Quantidade);
                AdicionaParametro("@Operacao", "!");
                if ((ExecutaComando(CommandType.StoredProcedure, "[dbo].[_spAlterarEstoque]")) != null)
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
        public bool updateEstoqueComId(Comanda estoque)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Id", estoque.IdProduto);
                AdicionaParametro("@Quantidade", estoque.Quantidade);
                AdicionaParametro("@Operacao", "!");
                if ((ExecutaComando(CommandType.StoredProcedure, "[dbo].[_aspAlteraEstoquePorID]")) != null)
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
	
    }
}
