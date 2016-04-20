namespace SysOticaForm
{
    partial class teste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sysOticaDataSet = new SysOticaForm.SysOticaDataSet();
            this.sysOticaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new SysOticaForm.SysOticaDataSetTableAdapters.clienteTableAdapter();
            this.clidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldatanascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltelefone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clenderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnomepaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnomemaeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clprofissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clobservacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysOticaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysOticaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clidDataGridViewTextBoxColumn,
            this.clnomeDataGridViewTextBoxColumn,
            this.cldatanascimentoDataGridViewTextBoxColumn,
            this.clcpfDataGridViewTextBoxColumn,
            this.clrgDataGridViewTextBoxColumn,
            this.cltelefoneDataGridViewTextBoxColumn,
            this.clcelularDataGridViewTextBoxColumn,
            this.cltelefone2DataGridViewTextBoxColumn,
            this.clcepDataGridViewTextBoxColumn,
            this.clenderecoDataGridViewTextBoxColumn,
            this.clnumeroDataGridViewTextBoxColumn,
            this.clbairroDataGridViewTextBoxColumn,
            this.clcidadeDataGridViewTextBoxColumn,
            this.clufDataGridViewTextBoxColumn,
            this.clemailDataGridViewTextBoxColumn,
            this.clnomepaiDataGridViewTextBoxColumn,
            this.clnomemaeDataGridViewTextBoxColumn,
            this.clprofissaoDataGridViewTextBoxColumn,
            this.clobservacoesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // sysOticaDataSet
            // 
            this.sysOticaDataSet.DataSetName = "SysOticaDataSet";
            this.sysOticaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sysOticaDataSetBindingSource
            // 
            this.sysOticaDataSetBindingSource.DataSource = this.sysOticaDataSet;
            this.sysOticaDataSetBindingSource.Position = 0;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.sysOticaDataSetBindingSource;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clidDataGridViewTextBoxColumn
            // 
            this.clidDataGridViewTextBoxColumn.DataPropertyName = "cl_id";
            this.clidDataGridViewTextBoxColumn.HeaderText = "cl_id";
            this.clidDataGridViewTextBoxColumn.Name = "clidDataGridViewTextBoxColumn";
            this.clidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clnomeDataGridViewTextBoxColumn
            // 
            this.clnomeDataGridViewTextBoxColumn.DataPropertyName = "cl_nome";
            this.clnomeDataGridViewTextBoxColumn.HeaderText = "cl_nome";
            this.clnomeDataGridViewTextBoxColumn.Name = "clnomeDataGridViewTextBoxColumn";
            // 
            // cldatanascimentoDataGridViewTextBoxColumn
            // 
            this.cldatanascimentoDataGridViewTextBoxColumn.DataPropertyName = "cl_datanascimento";
            this.cldatanascimentoDataGridViewTextBoxColumn.HeaderText = "cl_datanascimento";
            this.cldatanascimentoDataGridViewTextBoxColumn.Name = "cldatanascimentoDataGridViewTextBoxColumn";
            // 
            // clcpfDataGridViewTextBoxColumn
            // 
            this.clcpfDataGridViewTextBoxColumn.DataPropertyName = "cl_cpf";
            this.clcpfDataGridViewTextBoxColumn.HeaderText = "cl_cpf";
            this.clcpfDataGridViewTextBoxColumn.Name = "clcpfDataGridViewTextBoxColumn";
            // 
            // clrgDataGridViewTextBoxColumn
            // 
            this.clrgDataGridViewTextBoxColumn.DataPropertyName = "cl_rg";
            this.clrgDataGridViewTextBoxColumn.HeaderText = "cl_rg";
            this.clrgDataGridViewTextBoxColumn.Name = "clrgDataGridViewTextBoxColumn";
            // 
            // cltelefoneDataGridViewTextBoxColumn
            // 
            this.cltelefoneDataGridViewTextBoxColumn.DataPropertyName = "cl_telefone";
            this.cltelefoneDataGridViewTextBoxColumn.HeaderText = "cl_telefone";
            this.cltelefoneDataGridViewTextBoxColumn.Name = "cltelefoneDataGridViewTextBoxColumn";
            // 
            // clcelularDataGridViewTextBoxColumn
            // 
            this.clcelularDataGridViewTextBoxColumn.DataPropertyName = "cl_celular";
            this.clcelularDataGridViewTextBoxColumn.HeaderText = "cl_celular";
            this.clcelularDataGridViewTextBoxColumn.Name = "clcelularDataGridViewTextBoxColumn";
            // 
            // cltelefone2DataGridViewTextBoxColumn
            // 
            this.cltelefone2DataGridViewTextBoxColumn.DataPropertyName = "cl_telefone2";
            this.cltelefone2DataGridViewTextBoxColumn.HeaderText = "cl_telefone2";
            this.cltelefone2DataGridViewTextBoxColumn.Name = "cltelefone2DataGridViewTextBoxColumn";
            // 
            // clcepDataGridViewTextBoxColumn
            // 
            this.clcepDataGridViewTextBoxColumn.DataPropertyName = "cl_cep";
            this.clcepDataGridViewTextBoxColumn.HeaderText = "cl_cep";
            this.clcepDataGridViewTextBoxColumn.Name = "clcepDataGridViewTextBoxColumn";
            // 
            // clenderecoDataGridViewTextBoxColumn
            // 
            this.clenderecoDataGridViewTextBoxColumn.DataPropertyName = "cl_endereco";
            this.clenderecoDataGridViewTextBoxColumn.HeaderText = "cl_endereco";
            this.clenderecoDataGridViewTextBoxColumn.Name = "clenderecoDataGridViewTextBoxColumn";
            // 
            // clnumeroDataGridViewTextBoxColumn
            // 
            this.clnumeroDataGridViewTextBoxColumn.DataPropertyName = "cl_numero";
            this.clnumeroDataGridViewTextBoxColumn.HeaderText = "cl_numero";
            this.clnumeroDataGridViewTextBoxColumn.Name = "clnumeroDataGridViewTextBoxColumn";
            // 
            // clbairroDataGridViewTextBoxColumn
            // 
            this.clbairroDataGridViewTextBoxColumn.DataPropertyName = "cl_bairro";
            this.clbairroDataGridViewTextBoxColumn.HeaderText = "cl_bairro";
            this.clbairroDataGridViewTextBoxColumn.Name = "clbairroDataGridViewTextBoxColumn";
            // 
            // clcidadeDataGridViewTextBoxColumn
            // 
            this.clcidadeDataGridViewTextBoxColumn.DataPropertyName = "cl_cidade";
            this.clcidadeDataGridViewTextBoxColumn.HeaderText = "cl_cidade";
            this.clcidadeDataGridViewTextBoxColumn.Name = "clcidadeDataGridViewTextBoxColumn";
            // 
            // clufDataGridViewTextBoxColumn
            // 
            this.clufDataGridViewTextBoxColumn.DataPropertyName = "cl_uf";
            this.clufDataGridViewTextBoxColumn.HeaderText = "cl_uf";
            this.clufDataGridViewTextBoxColumn.Name = "clufDataGridViewTextBoxColumn";
            // 
            // clemailDataGridViewTextBoxColumn
            // 
            this.clemailDataGridViewTextBoxColumn.DataPropertyName = "cl_email";
            this.clemailDataGridViewTextBoxColumn.HeaderText = "cl_email";
            this.clemailDataGridViewTextBoxColumn.Name = "clemailDataGridViewTextBoxColumn";
            // 
            // clnomepaiDataGridViewTextBoxColumn
            // 
            this.clnomepaiDataGridViewTextBoxColumn.DataPropertyName = "cl_nomepai";
            this.clnomepaiDataGridViewTextBoxColumn.HeaderText = "cl_nomepai";
            this.clnomepaiDataGridViewTextBoxColumn.Name = "clnomepaiDataGridViewTextBoxColumn";
            // 
            // clnomemaeDataGridViewTextBoxColumn
            // 
            this.clnomemaeDataGridViewTextBoxColumn.DataPropertyName = "cl_nomemae";
            this.clnomemaeDataGridViewTextBoxColumn.HeaderText = "cl_nomemae";
            this.clnomemaeDataGridViewTextBoxColumn.Name = "clnomemaeDataGridViewTextBoxColumn";
            // 
            // clprofissaoDataGridViewTextBoxColumn
            // 
            this.clprofissaoDataGridViewTextBoxColumn.DataPropertyName = "cl_profissao";
            this.clprofissaoDataGridViewTextBoxColumn.HeaderText = "cl_profissao";
            this.clprofissaoDataGridViewTextBoxColumn.Name = "clprofissaoDataGridViewTextBoxColumn";
            // 
            // clobservacoesDataGridViewTextBoxColumn
            // 
            this.clobservacoesDataGridViewTextBoxColumn.DataPropertyName = "cl_observacoes";
            this.clobservacoesDataGridViewTextBoxColumn.HeaderText = "cl_observacoes";
            this.clobservacoesDataGridViewTextBoxColumn.Name = "clobservacoesDataGridViewTextBoxColumn";
            // 
            // teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 294);
            this.Controls.Add(this.dataGridView1);
            this.Name = "teste";
            this.Text = "teste";
            this.Load += new System.EventHandler(this.teste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysOticaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysOticaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sysOticaDataSetBindingSource;
        private SysOticaDataSet sysOticaDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SysOticaDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldatanascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltelefone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clenderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnomepaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnomemaeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clprofissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clobservacoesDataGridViewTextBoxColumn;
    }
}