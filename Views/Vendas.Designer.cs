namespace CantinaDoTioBill.View
{
    partial class FrmVendas
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
            this.bntSair = new System.Windows.Forms.Button();
            this.bntAdicionar = new System.Windows.Forms.Button();
            this.dtvVendas = new System.Windows.Forms.DataGridView();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCifrao = new System.Windows.Forms.Label();
            this.lblTotalVendas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // bntSair
            // 
            this.bntSair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bntSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSair.Location = new System.Drawing.Point(690, 342);
            this.bntSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 46);
            this.bntSair.TabIndex = 1;
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
            this.bntAdicionar.Location = new System.Drawing.Point(641, 78);
            this.bntAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntAdicionar.Name = "bntAdicionar";
            this.bntAdicionar.Size = new System.Drawing.Size(124, 61);
            this.bntAdicionar.TabIndex = 0;
            this.bntAdicionar.Text = "Adicionar";
            this.bntAdicionar.UseVisualStyleBackColor = true;
            this.bntAdicionar.Click += new System.EventHandler(this.bntAdicionar_Click);
            // 
            // dtvVendas
            // 
            this.dtvVendas.AllowUserToAddRows = false;
            this.dtvVendas.AllowUserToDeleteRows = false;
            this.dtvVendas.AllowUserToResizeColumns = false;
            this.dtvVendas.AllowUserToResizeRows = false;
            this.dtvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvVendas.ColumnHeadersVisible = false;
            this.dtvVendas.Location = new System.Drawing.Point(12, 47);
            this.dtvVendas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtvVendas.Name = "dtvVendas";
            this.dtvVendas.ReadOnly = true;
            this.dtvVendas.RowHeadersWidth = 51;
            this.dtvVendas.RowTemplate.Height = 24;
            this.dtvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvVendas.Size = new System.Drawing.Size(613, 298);
            this.dtvVendas.TabIndex = 56;
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConcluirVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConcluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluirVenda.Location = new System.Drawing.Point(641, 147);
            this.btnConcluirVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(124, 61);
            this.btnConcluirVenda.TabIndex = 57;
            this.btnConcluirVenda.Text = "Concluir Venda";
            this.btnConcluirVenda.UseVisualStyleBackColor = true;
            this.btnConcluirVenda.Click += new System.EventHandler(this.btnConcluirVenda_Click);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarVenda.BackColor = System.Drawing.Color.Red;
            this.btnCancelarVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenda.Location = new System.Drawing.Point(641, 216);
            this.btnCancelarVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(124, 59);
            this.btnCancelarVenda.TabIndex = 58;
            this.btnCancelarVenda.Text = "CancelarVenda";
            this.btnCancelarVenda.UseVisualStyleBackColor = false;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 59;
            this.label1.Text = "Lista de Vendas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(231, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 31);
            this.label2.TabIndex = 60;
            this.label2.Text = "Total de Vendas:";
            // 
            // lblCifrao
            // 
            this.lblCifrao.AutoSize = true;
            this.lblCifrao.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCifrao.Location = new System.Drawing.Point(405, 357);
            this.lblCifrao.Name = "lblCifrao";
            this.lblCifrao.Size = new System.Drawing.Size(40, 31);
            this.lblCifrao.TabIndex = 61;
            this.lblCifrao.Text = "R$";
            this.lblCifrao.Visible = false;
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.AutoSize = true;
            this.lblTotalVendas.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalVendas.Location = new System.Drawing.Point(438, 357);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(163, 31);
            this.lblTotalVendas.TabIndex = 62;
            this.lblTotalVendas.Text = "totalDeVendas";
            this.lblTotalVendas.Visible = false;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 401);
            this.Controls.Add(this.lblTotalVendas);
            this.Controls.Add(this.lblCifrao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.btnConcluirVenda);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.dtvVendas);
            this.Controls.Add(this.bntAdicionar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntAdicionar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.DataGridView dtvVendas;
        private Button btnConcluirVenda;
        private Button btnCancelarVenda;
        private Label label1;
        private Label label2;
        private Label lblCifrao;
        private Label lblTotalVendas;
    }
}