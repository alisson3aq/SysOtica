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
    public class ProdutoControlador
    {
        ProdutoDados ControladorProduto = new ProdutoDados();



        public void verificaPreenchimento(Produto produto)
        {

            if (String.IsNullOrEmpty(produto.Pr_descricao))
            {
                throw new CampoVazioException("Campo vazio!");
            }
            if (produto.Pr_qtd.Equals(""))
            {
                throw new CampoVazioException("Campo quantidade vazio!");
            }

            if (produto.Pr_valor.Equals(""))
            {
                throw new CampoVazioException("Campo Valor vazio!");
            }
            if (produto.Pr_estoqueminimo.Equals(""))
            {
                throw new CampoVazioException("Campo  Estoque vazio!");
            }

        }


        public void Cadastra(Produto produto)
        {


        }


        public void Excluir(Produto produto)
        {
           

        }



    }
}
