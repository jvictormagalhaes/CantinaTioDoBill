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
            this.dtvVendas = new System.Windows.Forms.DataGridView();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCifraoF = new System.Windows.Forms.Label();
            this.lblTotalVendasFinalizadas = new System.Windows.Forms.Label();
            this.lblTotalDeVendasCanceladas = new System.Windows.Forms.Label();
            this.lblCifraoC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.bntSair.Location = new System.Drawing.Point(670, 389);
            this.bntSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(95, 36);
            this.bntSair.TabIndex = 1;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
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
            this.dtvVendas.Location = new System.Drawing.Point(13, 47);
            this.dtvVendas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtvVendas.Name = "dtvVendas";
            this.dtvVendas.ReadOnly = true;
            this.dtvVendas.RowHeadersVisible = false;
            this.dtvVendas.RowHeadersWidth = 51;
            this.dtvVendas.RowTemplate.Height = 24;
            this.dtvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvVendas.Size = new System.Drawing.Size(613, 310);
            this.dtvVendas.TabIndex = 56;
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConcluirVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConcluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluirVenda.Location = new System.Drawing.Point(641, 115);
            this.btnConcluirVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(124, 67);
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
            this.btnCancelarVenda.Location = new System.Drawing.Point(641, 190);
            this.btnCancelarVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(124, 74);
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
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 28);
            this.label2.TabIndex = 60;
            this.label2.Text = "Total de Vendas Finalizadas";
            // 
            // lblCifraoF
            // 
            this.lblCifraoF.AutoSize = true;
            this.lblCifraoF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCifraoF.Location = new System.Drawing.Point(48, 389);
            this.lblCifraoF.Name = "lblCifraoF";
            this.lblCifraoF.Size = new System.Drawing.Size(35, 28);
            this.lblCifraoF.TabIndex = 61;
            this.lblCifraoF.Text = "R$";
            this.lblCifraoF.Visible = false;
            // 
            // lblTotalVendasFinalizadas
            // 
            this.lblTotalVendasFinalizadas.AutoSize = true;
            this.lblTotalVendasFinalizadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalVendasFinalizadas.Location = new System.Drawing.Point(79, 389);
            this.lblTotalVendasFinalizadas.Name = "lblTotalVendasFinalizadas";
            this.lblTotalVendasFinalizadas.Size = new System.Drawing.Size(234, 28);
            this.lblTotalVendasFinalizadas.TabIndex = 62;
            this.lblTotalVendasFinalizadas.Text = "totalDeVendasFinalizadas";
            this.lblTotalVendasFinalizadas.Visible = false;
            // 
            // lblTotalDeVendasCanceladas
            // 
            this.lblTotalDeVendasCanceladas.AutoSize = true;
            this.lblTotalDeVendasCanceladas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDeVendasCanceladas.Location = new System.Drawing.Point(381, 389);
            this.lblTotalDeVendasCanceladas.Name = "lblTotalDeVendasCanceladas";
            this.lblTotalDeVendasCanceladas.Size = new System.Drawing.Size(236, 28);
            this.lblTotalDeVendasCanceladas.TabIndex = 65;
            this.lblTotalDeVendasCanceladas.Text = "totalDeVendasCanceladas";
            this.lblTotalDeVendasCanceladas.Visible = false;
            // 
            // lblCifraoC
            // 
            this.lblCifraoC.AutoSize = true;
            this.lblCifraoC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCifraoC.Location = new System.Drawing.Point(350, 389);
            this.lblCifraoC.Name = "lblCifraoC";
            this.lblCifraoC.Size = new System.Drawing.Size(35, 28);
            this.lblCifraoC.TabIndex = 64;
            this.lblCifraoC.Text = "R$";
            this.lblCifraoC.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(319, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 28);
            this.label5.TabIndex = 63;
            this.label5.Text = "Total de Vendas Canceladas:";
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 438);
            this.Controls.Add(this.lblTotalDeVendasCanceladas);
            this.Controls.Add(this.lblCifraoC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalVendasFinalizadas);
            this.Controls.Add(this.lblCifraoF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.btnConcluirVenda);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.dtvVendas);
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
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.DataGridView dtvVendas;
        private Button btnConcluirVenda;
        private Button btnCancelarVenda;
        private Label label1;
        private Label label2;
        private Label lblCifraoF;
        private Label lblTotalVendasFinalizadas;
        private Label lblTotalDeVendasCanceladas;
        private Label lblCifraoC;
        private Label label5;
    }
}