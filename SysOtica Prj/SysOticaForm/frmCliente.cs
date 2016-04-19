using SysOtica.Negocio;
using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOticaForm
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }


        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                {
                    cliente.Cl_nome = textBoxNome.Text;
                    cliente.Cl_datanascimento = DateTime.Parse(maskedTextBoxDataNascimento.Text);
                    cliente.Cl_cpf = textBoxCPF.Text;
                    cliente.Cl_rg = textBoxRg.Text;
                    cliente.Cl_telefone = maskedTextBoxTelefone.Text;
                    cliente.Cl_celular = maskedTextBoxCelular.Text;
                    cliente.Cl_telefone2 = maskedTextBoxTelefone2.Text;
                    cliente.Cl_cep = maskedTextBoxCep.Text;
                    cliente.Cl_endereco = textBoxEndereco.Text;
                    cliente.Cl_numero = textBoxNumero.Text;
                    cliente.Cl_bairro = textBoxBairro.Text;
                    cliente.Cl_cidade = textBoxCidade.Text;
                    cliente.Cl_email = textBoxEmail.Text;
                    cliente.Cl_nomepai = textBoxNomepai.Text;
                    cliente.Cl_nomemae = textBoxNomemae.Text;
                    cliente.Cl_profissao = textBoxProfissao.Text;
                    cliente.Cl_observacoes = richTextBoxObservacoes.Text;
                    cliente.Cl_uf = textBoxUF.Text;
                }

                Fachada fachada = new Fachada();
                fachada.Insert(cliente);
                //new ClienteDados().Inserir(cliente);
                MessageBox.Show("Cliente Cadastrado !");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Cadastro " + ex.Message);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        public void LimparCampos()
        {
            textBoxNome.Text = "";
            maskedTextBoxDataNascimento.Text = "";
            textBoxCPF.Text = "";
            textBoxRg.Text = "";
            maskedTextBoxTelefone.Text = "";
            maskedTextBoxCelular.Text = "";
            maskedTextBoxTelefone2.Text = "";
            maskedTextBoxCep.Text = "";
            textBoxEndereco.Text = "";
            textBoxNumero.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            textBoxEmail.Text = "";
            textBoxNomepai.Text = "";
            textBoxNomemae.Text = "";
            textBoxProfissao.Text = "";
            richTextBoxObservacoes.Text = "";
            textBoxUF.Text = "";
        }
    }
}
