using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class VendaDAO:Conection
    {
        public bool SelectProdutoPorID(Comanda comanda)
        {
            try
            {
                LimparParametros();

                AdicionaParametro("@IDCOMANDA", comanda.IdComanda);
                AdicionaParametro("@IDPRODUTO", comanda.IdProduto);
                AdicionaParametro("@QUANTIDADE", comanda.Quantidade);
                if ((ExecutaComando(CommandType.StoredProcedure, "T__aspSomaVendaComComandaAtivaPorIDDoProduto")) != null)
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
        public bool SelectProdutoPorCodigo(Comanda comanda)
        {
            try
            {
                LimparParametros();

                AdicionaParametro("@IDCOMANDA", comanda.IdComanda);
                AdicionaParametro("@CoDigoProduto", comanda.CodigoProduto);
                AdicionaParametro("@QUANTIDADE", comanda.Quantidade);
                if ((ExecutaComando(CommandType.StoredProcedure, "T__aspSomaVendaComComandaAtivaPorCodigoDoProduto")) != null)
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
