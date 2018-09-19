using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pedido
    {
        public Cliente cliente { get; set; }
        public List<ItemPedido> itens { get; set; }
        public DateTime data { get; set; }
    }
}
