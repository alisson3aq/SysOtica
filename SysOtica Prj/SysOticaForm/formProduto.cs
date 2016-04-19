using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysOtica;
using SysOtica.Negocio;
using SysOtica.Negocio.Classes_Basicas;


namespace SysOticaForm
{
    public partial class formProduto : Form
    {
        public formProduto()
        {
            InitializeComponent();
        }


        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Fachada fachada = new Fachada();
                Fornecedor fornecedor = new Fornecedor();
                Produto produto = new Produto();
                {
                    produto.Pr_descricao = tbDescricao.Text;
                    produto.Pr_unidade = cbUnidade.Text;
                    int Fr_id = !String.IsNullOrEmpty(cbFornecedor.Text) ? Convert.ToInt32(cbFornecedor.SelectedValue.ToString()) : 0;
                    //produto.Fr_id = fachada.GetFornecedor(Fr_id);
                    produto.Pr_grupo = cbGrupo.Text;
                    produto.Pr_grife = cbGrife.Text;
                    produto.Pr_valor = int.Parse(tbValor.Text);
                    produto.Pr_qtd = int.Parse(tbQuantidade.Text);
                    produto.Pr_estoqueminimo = int.Parse(tbEstoqueMinimo.Text);

                }
                fachada.CadastrarProduto(produto);
                //new ProdutoDados().inserir(produto);
                MessageBox.Show("Produto Cadastrado com Sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no Cadastro" + ex.Message);
            }
        }

        private void formProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        public void LimparCampos()
        {
            tbDescricao.Text = "";
            cbUnidade.Text = "";
            cbFornecedor.Text = "";
            cbGrupo.Text = "";
            cbGrife.Text = "";
            tbValor.Text = "";
            tbQuantidade.Text = "";
            tbEstoqueMinimo.Text = "";
        }

        private void formProduto_Load(object sender, EventArgs e)
        {
            //SysOtica.Conexão.FornecedorDados forn = new FornecedorDados();
            //List<Fornecedor> lista = forn.listaFornecedor();
            //cbFornecedor.DataSource = lista;
            //cbFornecedor.DisplayMember = "fr_fantasia";
            //cbFornecedor.ValueMember = "fr_id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFornecedor nvfrn = new frmFornecedor();
            nvfrn.Show();
        }
    }
}
