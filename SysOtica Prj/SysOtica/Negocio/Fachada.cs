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
        //Fornecedor
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

        //public Fornecedor GetFornecedor(int id)
        //{
        //    return fornControl.GetFornecedor(id);
        //}

        //Usuario
        UsuarioControlador usu = new UsuarioControlador();
        public void Insert(Usuario usuario)
        {
            usu.VerificaPreenchimento(usuario);
            usu.Insert(usuario);
        }
        public void Uptade(Usuario usuario)
        {
            usu.Uptade(usuario);
        }

        public void Delete(Usuario usuario)
        {
            usu.Delete(usuario);
        }
        public void Duplicidade(Usuario usuario)
        {
            usu.VerificaPreenchimento(usuario);
        }

        public List<Usuario> listaUsuario
        {
            get
            {
                return listaUsuario;
            }
        }


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

        public void Update(Cliente cliente)
        {
            clientecontrolador.Update(cliente);
        }

        public void Delete(Cliente cliente)
        {
           clientecontrolador.Delete(cliente);
        }
   
        public void Duplicidade(Cliente cliente)
        {

         clientecontrolador.Duplicidade(cliente);
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
        public void Insert(Receita receita)
        {
            recControlador.Insert(receita);
        }

        public void Update(Receita receita)
        {
            recControlador.Update(receita);
        }
        public void Delete(Receita receita)
        {
            recControlador.Delete(receita);
        }
        public void Duplicidade(Receita receita)
        {
            recControlador.VerificaPreenchimento(receita);
        }
        List<Receita> select1
        {
            get
            {
                return select1;
            }

        }





            //Produto
        ProdutoControlador controladorProduto = new ProdutoControlador();
        public void Insert(Produto produto)
        {
            controladorProduto.verificaPreenchimento(produto);
            controladorProduto.Insert(produto);
        }

        public void Update(Produto produto)
        {
            controladorProduto.Update(produto);
        }


        public void Delete(Produto produto)
        {
            controladorProduto.Delete(produto);
        }

        public void Duplicidade(Produto produto)
        {
            controladorProduto.Duplicidade(produto);
        }

        List<Produto> select
        {

            get
            {
                return select;
            }

        }











        #endregion
    }
}
