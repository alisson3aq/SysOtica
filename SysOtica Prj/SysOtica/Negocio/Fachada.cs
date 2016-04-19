using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Regras_de_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio
{
    public class Fachada
    {
        #region Leonardo
        FornecedorControlador fornControl = new FornecedorControlador();
        public void InserirFornecedor(Fornecedor fornecedor)
        {
            fornControl.InserirFornecedor(fornecedor);
        }
        public void VerificaPreenchimento(Fornecedor fornecedor)
        {
            fornControl.VerificaPreenchimento(fornecedor);
        }
        public void ExcluirFornecedor(int id)
        {
            fornControl.ExcluirFornecedor(id);
        }
        //public Fornecedor GetFornecedor(int id)
        //{
        //    return fornControl.GetFornecedor(id);
        //}

        #endregion

        #region Dayse
        /*########################################
          ###############CLIENTE##################
          ########################################
       */

        //Salva um Cliente novo no banco de Dados
        ClienteControlador clientecontrolador = new ClienteControlador();
        public void Insert(Cliente cliente)
        {
            clientecontrolador.verificaPreenchimento(cliente);
            clientecontrolador.Insert(cliente);
        }


        /*########################################
        ###############LOCAL##################
        ########################################
        */

        //Salva um Local novo no banco de Dados

        #endregion

        #region Carlão


        //Receita
        ReceitaControlador recControlador = new ReceitaControlador();
        public void CadastraReceita(Receita receita)
        {
            recControlador.Inserir(receita);
        }

        //Produto
        ProdutoControlador controladorProduto = new ProdutoControlador();
        public void ExcluirProduto(Produto produto)
        {
            controladorProduto.Excluir(produto);
        }

        public void CadastrarProduto(Produto produto)
        {
            controladorProduto.Cadastra(produto);
        }


        #endregion
    }
}
