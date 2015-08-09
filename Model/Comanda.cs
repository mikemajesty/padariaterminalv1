using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comanda 
    {
        public int IdComanda { get; set; }
        public string CodigoComanda { get; set; }
        //--------------------
        public string CodigoProduto { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public double PrecoVenda { get; set; }
    }
}
