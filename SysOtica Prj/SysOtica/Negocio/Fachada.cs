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

        #region Fornecedor
        FornecedorControlador fornControl = new FornecedorControlador();
        public void InserirFornecedor(Fornecedor fornecedor)
        {
            fornControl.VerificaPreenchimento(fornecedor);
            fornControl.Insert(fornecedor);
        }
        public void VerificaPreenchimento(Fornecedor fornecedor)
        {
            fornControl.VerificaPreenchimento(fornecedor);
        }

        public void AlteraFornecedor(Fornecedor fornecedor)
        {
            fornControl.Update(fornecedor);
        }


        public void ExcluirFornecedor(Fornecedor fornecedor)
        {
            fornControl.Delete(fornecedor);
        }

        public void VerificaDuplicidade(Fornecedor fornecedor)
        {
            fornControl.VerificaDuplicidadeFornecedor(fornecedor);
        }



        #endregion

        #region Usuario
        UsuarioControlador usu = new UsuarioControlador();
        public void InserirUsuario(Usuario usuario)
        {
            usu.VerificaPreenchimento(usuario);
            usu.Insert(usuario);
        }
        public void AlterarUsuario(Usuario usuario)
        {
            usu.Uptade(usuario);
        }

        public void DeletarUsuario(Usuario usuario)
        {
            usu.Delete(usuario);
        }
        public void DuplicidadeUsuario(Usuario usuario)
        {
            usu.VerificaPreenchimento(usuario);
        }
        #endregion

        #region Cliente

        //Salva um Cliente novo no banco de Dados
        ClienteControlador clientecontrolador = new ClienteControlador();
        public void InserirCliente(Cliente cliente)
        {
            clientecontrolador.verificaPreenchimento(cliente);
            clientecontrolador.Insert(cliente);
        }

        public void AlterarCliente(Cliente cliente)
        {
            clientecontrolador.Update(cliente);
        }

        public void DeletarCliente(Cliente cliente)
        {
            clientecontrolador.Delete(cliente);
        }

        public void DuplicidadeCliente(Cliente cliente)
        {

            clientecontrolador.Duplicidade(cliente);
        }
        #endregion

        #region Receita
        ReceitaControlador recControlador = new ReceitaControlador();
        public void InserirReceita(Receita receita)
        {
            recControlador.Insert(receita);
        }

        public void AlterarReceita(Receita receita)
        {
            recControlador.Update(receita);
        }
        public void DeletarReceita(Receita receita)
        {
            recControlador.Delete(receita);
        }
        public void DuplicidadeReceita(Receita receita)
        {
            recControlador.VerificaPreenchimento(receita);
        }

        public void Insert(Receita receita)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Produto
        ProdutoControlador controladorProduto = new ProdutoControlador();
        public void InserirProduto(Produto produto)
        {
            controladorProduto.verificaPreenchimento(produto);
            controladorProduto.Insert(produto);
        }

        public void AlterarProduto(Produto produto)
        {
            controladorProduto.Update(produto);
        }


        public void DeletarProduto(Produto produto)
        {
            controladorProduto.Delete(produto);
        }

        public void DuplicidadeProduto(Produto produto)
        {
            controladorProduto.Duplicidade(produto);
        }
        #endregion

    }
}
