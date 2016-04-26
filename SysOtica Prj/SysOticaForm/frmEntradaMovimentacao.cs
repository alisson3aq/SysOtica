using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysOtica.Conexao;
using SysOtica.Negocio.Classes_Basicas;

namespace SysOticaForm
{
    public partial class frmEntradaMovimentacao : Form
    {
        public frmEntradaMovimentacao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmEntradaMovimentacao_Load(object sender, EventArgs e)
        {
            CarregaForncedores();

            CarregaProduto();


        }

        public void LimparCampos()
        {

            txtQuantidade.Text = "";
            dateTimePickerdtentrada.Text = "";
            cmbTipo.Text = "";
            richTxtObservacoes.Text = "";
            cmbFornecedor.Text = "";
            cmbProduto.Text = "";

        }

        private void CarregaProduto()
        {
            ProdutoDados pd = new ProdutoDados();
            string items;
            Produto p = new Produto();
            List<Produto> carregaproduto = pd.pegaproduto();

            for (int i = 0; i < carregaproduto.Count(); i++)
            {
                p = carregaproduto[i];
                items = p.Pr_id + " -  " + p.Pr_descricao;
                cmbProduto.Items.Add(items);

            }

        }


        private void CarregaForncedores()
        {

            FornecedoresDados fd = new FornecedoresDados();
            string item;
            Fornecedor forn = new Fornecedor();
            List<Fornecedor> carregaforn = fd.pegaFornenedor();
            for (int i = 0; i < carregaforn.Count(); i++)
            {

                forn = carregaforn[i];
                item = forn.Fr_id + "  -  " + forn.Fr_fantasia;
                cmbFornecedor.Items.Add(item);

            }

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            ProdutoFornecedor pf = new ProdutoFornecedor();

            try
            {
                ProdutoFornecedorDados pfd = new ProdutoFornecedorDados();

              // string forn = cmbFornecedor.SelectedItem.ToString();
               //int fornecedorID = Convert.ToInt32(forn.Substring(0,1));

                //int p = Convert.ToInt32(cmbProduto.SelectedItem.ToString().Substring(0, 1));
                //int produtoID = Convert.ToInt32(p.Substring(0,1));


                //pf.Fr_id = Convert.ToInt32(fornecedorID);
                //pf.Pr_id = p;
                pf.Pf_qtd = Convert.ToInt32(txtQuantidade.Text);
                pf.Pf_dtentrada = Convert.ToDateTime(dateTimePickerdtentrada.Text);
                pf.Pf_tipo = cmbTipo.SelectedItem.ToString();
                pf.Pf_observacoes = richTxtObservacoes.Text;

               
                pfd.inserir(pf);

                MessageBox.Show("Produto fornecedor inserido com sucesso!");
                LimparCampos();


            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir Produto ao Fornecedor" + ex.Message);

            }






        }
    }
}
