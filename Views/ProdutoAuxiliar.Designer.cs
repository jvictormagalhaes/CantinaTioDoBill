namespace CantinaDoTioBill.Views
{
    partial class FrmProdutoAuxiliar
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtvProdutos = new System.Windows.Forms.DataGridView();
            this.btnSelecionarProduto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Lista de Produtos";
            // 
            // dtvProdutos
            // 
            this.dtvProdutos.AllowUserToAddRows = false;
            this.dtvProdutos.AllowUserToDeleteRows = false;
            this.dtvProdutos.AllowUserToResizeColumns = false;
            this.dtvProdutos.AllowUserToResizeRows = false;
            this.dtvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvProdutos.Location = new System.Drawing.Point(12, 38);
            this.dtvProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtvProdutos.Name = "dtvProdutos";
            this.dtvProdutos.RowHeadersVisible = false;
            this.dtvProdutos.RowHeadersWidth = 51;
            this.dtvProdutos.RowTemplate.Height = 24;
            this.dtvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvProdutos.Size = new System.Drawing.Size(613, 254);
            this.dtvProdutos.TabIndex = 59;
            // 
            // btnSelecionarProduto
            // 
            this.btnSelecionarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarProduto.Location = new System.Drawing.Point(411, 310);
            this.btnSelecionarProduto.Name = "btnSelecionarProduto";
            this.btnSelecionarProduto.Size = new System.Drawing.Size(105, 29);
            this.btnSelecionarProduto.TabIndex = 61;
            this.btnSelecionarProduto.Text = "Selecionar";
            this.btnSelecionarProduto.UseVisualStyleBackColor = true;
            this.btnSelecionarProduto.Click += new System.EventHandler(this.btnSelecionarProduto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(522, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 29);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmProdutoAuxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 351);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSelecionarProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvProdutos);
            this.Name = "FrmProdutoAuxiliar";
            this.Text = "Lista de Produtos";
            this.Load += new System.EventHandler(this.ProdutoAuxiliar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnSelecionarProduto;
        private Button btnCancelar;
        public DataGridView dtvProdutos;
    }
}