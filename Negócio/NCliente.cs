using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negócio
{
    public class NCliente
    {
        private List<Cliente> clientes = new List<Cliente>();
        private PCliente pc = new PCliente();

        public List<Cliente> Select()
        {
            clientes = pc.Abrir().OrderBy(c => c.nome).ToList();
            return clientes;
        }
        public void Insert(Cliente c)
        {
            clientes = pc.Abrir().ToList();
            // Calcula o id do novo contato
            if (clientes.Count == 0) c.id = 1;
            else c.id = clientes.Max(x => x.id) + 1;
            clientes.Add(c);
            pc.Salvar(clientes);
        }
        public void Update(Cliente c)
        {
            clientes = pc.Abrir();
            // Busca o contato que vai ser alterado pelo nome
            Cliente r = clientes.Where(x => x.id == c.id).Single();
            clientes.Remove(r);
            clientes.Add(c);
            pc.Salvar(clientes);
        }
        public void Delete(Cliente c)
        {
            clientes = pc.Abrir();
            // Busca o contato que vai ser removido pelo id
            Cliente r = clientes.Where(x => x.id == c.id).Single();
            clientes.Remove(r);
            pc.Salvar(clientes);
        }
    }
}
