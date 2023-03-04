namespace CantinaDoTioBill.Views
{
    partial class FrmClienteAuxiliar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtvClientesAuxiliar = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvClientesAuxiliar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvClientesAuxiliar
            // 
            this.dtvClientesAuxiliar.AllowUserToAddRows = false;
            this.dtvClientesAuxiliar.AllowUserToDeleteRows = false;
            this.dtvClientesAuxiliar.AllowUserToResizeColumns = false;
            this.dtvClientesAuxiliar.AllowUserToResizeRows = false;
            this.dtvClientesAuxiliar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvClientesAuxiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvClientesAuxiliar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNome,
            this.clmCpf,
            this.clmRg,
            this.clmTelefone,
            this.clmEndereco,
            this.clmNumero});
            this.dtvClientesAuxiliar.Location = new System.Drawing.Point(12, 49);
            this.dtvClientesAuxiliar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtvClientesAuxiliar.Name = "dtvClientesAuxiliar";
            this.dtvClientesAuxiliar.ReadOnly = true;
            this.dtvClientesAuxiliar.RowHeadersVisible = false;
            this.dtvClientesAuxiliar.RowHeadersWidth = 51;
            this.dtvClientesAuxiliar.RowTemplate.Height = 24;
            this.dtvClientesAuxiliar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvClientesAuxiliar.Size = new System.Drawing.Size(704, 264);
            this.dtvClientesAuxiliar.TabIndex = 57;
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "Id";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "D4";
            this.clmID.DefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmCpf.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmRg.DefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmTelefone.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "D4";
            this.clmNumero.DefaultCellStyle = dataGridViewCellStyle10;
            this.clmNumero.HeaderText = "Número";
            this.clmNumero.MinimumWidth = 6;
            this.clmNumero.Name = "clmNumero";
            this.clmNumero.ReadOnly = true;
            this.clmNumero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmNumero.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Lista de Clientes";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(512, 320);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 29);
            this.btnSalvar.TabIndex = 59;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(615, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 29);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmClienteAuxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 354);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvClientesAuxiliar);
            this.Name = "FrmClienteAuxiliar";
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.FrmClienteAuxiliar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvClientesAuxiliar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView dtvClientesAuxiliar;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmNome;
        private DataGridViewTextBoxColumn clmCpf;
        private DataGridViewTextBoxColumn clmRg;
        private DataGridViewTextBoxColumn clmTelefone;
        private DataGridViewTextBoxColumn clmEndereco;
        private DataGridViewTextBoxColumn clmNumero;
        private Label label1;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}