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
using SysOtica.Conexao;
using System.Collections;

namespace SysOticaForm
{
    public partial class formProduto : Form
    {
        string[] oculossol = {"Arnette","Blue Bay","Christian Dior", "D&G",
                               "Diesel","Armani","mormaii","Oakley","Ray-Ban","Ralph Lauren","HB" };

        string[] oculosgrau = {"Pirre Cardin","Hugo Boss","Tommy Hilfiger", "D&G",
                               "Turma da Mônica","Lacoste","Adidas","Playboy","Ray-Ban","Ralph Lauren","Evoke" };

        string[] grupo = { "Oculos de Grau", "Oculos de Sol" };

        //
       
        //
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
                    produto.Pr_grupo = cbGrupo.SelectedItem.ToString();
                    produto.Pr_grife = cbGrife.SelectedItem.ToString();
                    produto.Pr_valor = int.Parse(tbValor.Text);
                    produto.Pr_qtd = int.Parse(tbQuantidade.Text);
                    produto.Pr_estoqueminimo = int.Parse(tbEstoqueMinimo.Text);

                }
                fachada.InserirProduto(produto);
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

            for (int i = 0; i < grupo.Count(); i++)
            {
                cbGrupo.Items.Add(grupo[i]);
            }

            CarregaForncedores();
        }   
        private void button2_Click(object sender, EventArgs e)
        {
            frmFornecedor nvfrn = new frmFornecedor();
            nvfrn.Show();
        }

     
       
     
      private void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGrupo.SelectedIndex == 0)// seleciona o primeiro index do combobox
            {

                for (int i = 0; i < oculosgrau.Count(); i++) // carrega combobox caso o index selecionado seja = 0
                {
                    cbGrife.Items.Add(oculosgrau[i]);
                }

            }

            if (cbGrupo.SelectedIndex == 1)// seleciona o segundo index do combobox
            {
                cbGrife.Items.Clear();// Limpa os itens comboBox
                for (int j = 0; j < oculossol.Count(); j++) // carrega combobox caso o index selecionado seja = 1
                {
                    cbGrife.Items.Add(oculossol[j]);
                }

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
                item = forn.Fr_id +    "-"   +   forn.Fr_fantasia;
                cbFornecedor.Items.Add(item);

            }

   
        }


                /*string escolha1;

                escolha1 = cbGrife.SelectedItem.ToString();

                MessageBox.Show("a opção escolhida foi:  " + escolha1)*/
    }


}
