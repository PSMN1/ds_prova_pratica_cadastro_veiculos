namespace GerenciadorVeiculos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPrecoBase = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.lblParametro = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(54, 108);
            this.txtModelo.Multiline = true;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(164, 34);
            this.txtModelo.TabIndex = 0;
            this.txtModelo.Text = "Campo para digitar o modelo do veículo";
            // 
            // txtPrecoBase
            // 
            this.txtPrecoBase.Location = new System.Drawing.Point(54, 181);
            this.txtPrecoBase.Multiline = true;
            this.txtPrecoBase.Name = "txtPrecoBase";
            this.txtPrecoBase.Size = new System.Drawing.Size(164, 41);
            this.txtPrecoBase.TabIndex = 1;
            this.txtPrecoBase.Text = "Campo para digitar o preço base";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.cmbTipo.Location = new System.Drawing.Point(54, 256);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 2;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged_1);
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(352, 154);
            this.txtParametro.Multiline = true;
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(125, 41);
            this.txtParametro.TabIndex = 3;
            this.txtParametro.Text = "Campo para portas ou cilindradas";
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(312, 221);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(212, 13);
            this.lblParametro.TabIndex = 4;
            this.lblParametro.Text = "Rótulo que mudará de texto dinamicamente";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(601, 159);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 63);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar Veículo";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtPrecoBase);
            this.Controls.Add(this.txtModelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPrecoBase;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.Button btnSalvar;
    }
}

