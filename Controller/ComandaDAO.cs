using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ComandaDAO : Conection
    {
        public bool insertComandaPorPesoComId(Comanda comanda)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@IdComanda", comanda.IdComanda);
                AdicionaParametro("@IDPRODUTO", comanda.IdProduto);
                AdicionaParametro("@PRECOVENDA", comanda.PrecoVenda);
                if (ExecutaComando(CommandType.StoredProcedure, "_aspSomaVendaComandaPorPesoId") != null)
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
        public bool insertComandaPorPesoComCodigo(Comanda comanda)
        {
            try
            {

                
                LimparParametros();
                AdicionaParametro("@IdComanda", comanda.IdComanda);
                AdicionaParametro("@CoDigoProduto", comanda.CodigoProduto);
                AdicionaParametro("@PRECOVENDA", comanda.PrecoVenda);
                if (ExecutaComando(CommandType.StoredProcedure, "_aspSomaVendaComandaPorPesoPorCodigo") != null)
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
        public bool DeletePorId(int Id)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@IdComanda", Id);
                if (ExecutaComando(CommandType.StoredProcedure, "aspDeletVendaPorComandaAtivaPorId") != null)
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
        public bool SelectComanda(Comanda comanda)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@ID", comanda.IdComanda);
                if (ExecutaComando(CommandType.StoredProcedure, "_aspSelectComandaPorId") != null)
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
