namespace CantinaDoTioBill.View
{
    partial class FrmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEditar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.bntAdicionar = new System.Windows.Forms.Button();
            this.dtvClientes = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvClientes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(3, 82);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(104, 65);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bntSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSair.Location = new System.Drawing.Point(756, 349);
            this.bntSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(107, 31);
            this.bntSair.TabIndex = 4;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // bntAdicionar
            // 
            this.bntAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAdicionar.Location = new System.Drawing.Point(3, 4);
            this.bntAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntAdicionar.Name = "bntAdicionar";
            this.bntAdicionar.Size = new System.Drawing.Size(104, 70);
            this.bntAdicionar.TabIndex = 0;
            this.bntAdicionar.Text = "Adicionar";
            this.bntAdicionar.UseVisualStyleBackColor = true;
            this.bntAdicionar.Click += new System.EventHandler(this.bntAdicionar_Click);
            // 
            // dtvClientes
            // 
            this.dtvClientes.AllowUserToAddRows = false;
            this.dtvClientes.AllowUserToDeleteRows = false;
            this.dtvClientes.AllowUserToResizeColumns = false;
            this.dtvClientes.AllowUserToResizeRows = false;
            this.dtvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNome,
            this.clmCpf,
            this.clmRg,
            this.clmTelefone,
            this.clmEndereco,
            this.clmNumero});
            this.dtvClientes.Location = new System.Drawing.Point(12, 49);
            this.dtvClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtvClientes.Name = "dtvClientes";
            this.dtvClientes.ReadOnly = true;
            this.dtvClientes.RowHeadersVisible = false;
            this.dtvClientes.RowHeadersWidth = 51;
            this.dtvClientes.RowTemplate.Height = 24;
            this.dtvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvClientes.Size = new System.Drawing.Size(704, 319);
            this.dtvClientes.TabIndex = 56;
            this.dtvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvClientes_CellClick);
            this.dtvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvClientes_CellContentClick);
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "D4";
            this.clmID.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmID.HeaderText = "ID";
            this.clmID.MinimumWidth = 6;
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmID.Width = 80;
            // 
            // clmNome
            // 
            this.clmNome.DataPropertyName = "Nome";
            this.clmNome.HeaderText = "Nome";
            this.clmNome.MinimumWidth = 6;
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            this.clmNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmNome.Width = 150;
            // 
            // clmCpf
            // 
            this.clmCpf.DataPropertyName = "Cpf";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmCpf.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmCpf.HeaderText = "CPF";
            this.clmCpf.MinimumWidth = 6;
            this.clmCpf.Name = "clmCpf";
            this.clmCpf.ReadOnly = true;
            this.clmCpf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCpf.Width = 80;
            // 
            // clmRg
            // 
            this.clmRg.DataPropertyName = "Rg";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmRg.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmRg.HeaderText = "RG";
            this.clmRg.MinimumWidth = 6;
            this.clmRg.Name = "clmRg";
            this.clmRg.ReadOnly = true;
            this.clmRg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmRg.Width = 80;
            // 
            // clmTelefone
            // 
            this.clmTelefone.DataPropertyName = "Telefone";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmTelefone.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmTelefone.HeaderText = "Telefone";
            this.clmTelefone.MinimumWidth = 6;
            this.clmTelefone.Name = "clmTelefone";
            this.clmTelefone.ReadOnly = true;
            this.clmTelefone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmTelefone.Width = 80;
            // 
            // clmEndereco
            // 
            this.clmEndereco.DataPropertyName = "Endereco";
            this.clmEndereco.HeaderText = "Endereço";
            this.clmEndereco.MinimumWidth = 6;
            this.clmEndereco.Name = "clmEndereco";
            this.clmEndereco.ReadOnly = true;
            this.clmEndereco.Width = 150;
            // 
            // clmNumero
            // 
            this.clmNumero.DataPropertyName = "Numero";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "D4";
            this.clmNumero.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmNumero.HeaderText = "Número";
            this.clmNumero.MinimumWidth = 6;
            this.clmNumero.Name = "clmNumero";
            this.clmNumero.ReadOnly = true;
            this.clmNumero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmNumero.Width = 80;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnEditar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bntAdicionar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExcluir, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(756, 78);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(110, 225);
            this.tableLayoutPanel1.TabIndex = 53;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(3, 154);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(104, 68);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Lista de Clientes";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvClientes);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvClientes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnExcluir;
        private Label label1;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmNome;
        private DataGridViewTextBoxColumn clmCpf;
        private DataGridViewTextBoxColumn clmRg;
        private DataGridViewTextBoxColumn clmTelefone;
        private DataGridViewTextBoxColumn clmEndereco;
        private DataGridViewTextBoxColumn clmNumero;
        public DataGridView dtvClientes;
    }
}