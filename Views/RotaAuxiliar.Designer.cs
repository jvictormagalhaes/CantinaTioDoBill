namespace CantinaDoTioBill.Views
{
    partial class FrmRotaAuxiliar
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
            this.dtvRotas = new System.Windows.Forms.DataGridView();
            this.btnSelecionarRota = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Lista de Rotas";
            // 
            // dtvRotas
            // 
            this.dtvRotas.AllowUserToAddRows = false;
            this.dtvRotas.AllowUserToDeleteRows = false;
            this.dtvRotas.AllowUserToResizeColumns = false;
            this.dtvRotas.AllowUserToResizeRows = false;
            this.dtvRotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvRotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvRotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtvRotas.Location = new System.Drawing.Point(12, 38);
            this.dtvRotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtvRotas.Name = "dtvRotas";
            this.dtvRotas.ReadOnly = true;
            this.dtvRotas.RowHeadersVisible = false;
            this.dtvRotas.RowHeadersWidth = 51;
            this.dtvRotas.RowTemplate.Height = 24;
            this.dtvRotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvRotas.Size = new System.Drawing.Size(330, 168);
            this.dtvRotas.TabIndex = 64;
            // 
            // btnSelecionarRota
            // 
            this.btnSelecionarRota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarRota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarRota.Location = new System.Drawing.Point(137, 227);
            this.btnSelecionarRota.Name = "btnSelecionarRota";
            this.btnSelecionarRota.Size = new System.Drawing.Size(94, 29);
            this.btnSelecionarRota.TabIndex = 66;
            this.btnSelecionarRota.Text = "Selecionar";
            this.btnSelecionarRota.UseVisualStyleBackColor = true;
            this.btnSelecionarRota.Click += new System.EventHandler(this.btnSelecionarRota_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(237, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 29);
            this.btnCancelar.TabIndex = 67;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmRotaAuxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 268);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSelecionarRota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvRotas);
            this.Name = "FrmRotaAuxiliar";
            this.Text = "Lista de Rotas";
            this.Load += new System.EventHandler(this.FrmRotaAuxiliar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvRotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnSelecionarRota;
        private Button btnCancelar;
        public DataGridView dtvRotas;
    }
}