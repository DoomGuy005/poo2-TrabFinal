using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Modelo;

namespace Persistencia
{
    public class PCliente : Arquivo<List<Cliente>>
    {
        public PCliente() : base("lcliente.xml")
        {
        }
    }
}
