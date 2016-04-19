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
    public partial class frmListarCliente : Form
    {
        List<Cliente> listaCliente;

        public frmListarCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sysOticaDataSet);

        }

        private void frmListarCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysOticaDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.sysOticaDataSet.cliente);
            // TODO: This line of code loads data into the 'sysOticaDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.sysOticaDataSet.cliente);

        }

        private void clienteBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sysOticaDataSet);

        }

        private void clienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (clienteDataGridView.SelectedRows[0].Index >= 0)
            {
                //Cliente clienteSelecionado = listaCliente.ElementAt(clienteDataGridView.SelectedRows[0].Index);

                MessageBox.Show(Convert.ToString(clienteDataGridView.SelectedRows[0].Index).ToString());
                //frmCliente frmcl = new frmCliente();
                //frmcl.Show();
                //frmAltCliente alteraCl = new frmAltCliente();
                //alteraCl.Show();


            }
        }
    }
}
