using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ItemPedido
    {
        public int quantidade { get; set; }
        public Peca peca { get; set; }
        public decimal preco { get; set; }
    }
}
