using SysOtica.Conexao;
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
    public partial class frmAltCliente : Form
    {
        ClienteDados cd;

        public frmAltCliente()
        {
            InitializeComponent();
        }
        private void frmAltCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysOticaDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.sysOticaDataSet.cliente);
           
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmAltCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }


    }
}
