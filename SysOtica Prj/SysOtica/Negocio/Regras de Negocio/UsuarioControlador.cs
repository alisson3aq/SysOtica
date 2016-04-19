using SysOtica.Conexao;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Regras_de_Negocio
{
    public class UsuarioControlador
    {
        UsuarioDados user = new UsuarioDados();

        public void VerificaPreenchimento(Usuario usuario)
        {
            if (String.IsNullOrEmpty(usuario.Us_usuario)) { throw new CampoVazioException("Campo Usuario Vazio"); }
            if (String.IsNullOrEmpty(usuario.Us_senha)) { throw new CampoVazioException("Campo Senha Vazio"); }
            if (String.IsNullOrEmpty(usuario.Us_endereco)) { throw new CampoVazioException("Campo Endereço Vazio"); }
            if (String.IsNullOrEmpty(usuario.Us_nome)) { throw new CampoVazioException("Campo Nome Vazio"); }
            if (String.IsNullOrEmpty(usuario.Us_telefone)) { throw new CampoVazioException("Campo Telefone Vazio"); }
            if (String.IsNullOrEmpty(usuario.Us_tipo)) { throw new CampoVazioException("Campo Tipo Vazio"); }

        }

        public void Alterar(Usuario usuario)
        {
          
        }
        public void Excluir(int id)
        {
            
        }
        public void Inserir(Usuario usuario)
        {
           
        }
        public List<Usuario> listaUsuario
        {
            get
            {
                return listaUsuario;
            }
        }

        public Usuario RetornaUsuario(Usuario filtro)
        {
            return filtro;
        }
    }
}
