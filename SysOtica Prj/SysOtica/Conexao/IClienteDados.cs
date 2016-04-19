using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    public interface IClienteDados
    {
        void Insert(Cliente cliente);
        void update(Cliente cliente);
        void delete(Cliente cliente);
        bool verificaduplicidade(Cliente cliente);
        List<Cliente> select(Cliente filtro);
    }
}
