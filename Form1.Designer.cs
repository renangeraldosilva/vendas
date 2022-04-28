namespace Aula31
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
            this.label1 = new System.Windows.Forms.Label();
            this.textProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPreco = new System.Windows.Forms.TextBox();
            this.listProduto = new System.Windows.Forms.ListBox();
            this.listPreco = new System.Windows.Forms.ListBox();
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.bntRemover = new System.Windows.Forms.Button();
            this.bntLancar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto ";
            // 
            // textProduto
            // 
            this.textProduto.Location = new System.Drawing.Point(109, 53);
            this.textProduto.Name = "textProduto";
            this.textProduto.Size = new System.Drawing.Size(100, 20);
            this.textProduto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Preço ";
            // 
            // textPreco
            // 
            this.textPreco.Location = new System.Drawing.Point(276, 53);
            this.textPreco.Name = "textPreco";
            this.textPreco.Size = new System.Drawing.Size(100, 20);
            this.textPreco.TabIndex = 1;
            // 
            // listProduto
            // 
            this.listProduto.FormattingEnabled = true;
            this.listProduto.Location = new System.Drawing.Point(37, 168);
            this.listProduto.Name = "listProduto";
            this.listProduto.Size = new System.Drawing.Size(172, 225);
            this.listProduto.TabIndex = 2;
            // 
            // listPreco
            // 
            this.listPreco.FormattingEnabled = true;
            this.listPreco.Location = new System.Drawing.Point(232, 168);
            this.listPreco.Name = "listPreco";
            this.listPreco.Size = new System.Drawing.Size(172, 225);
            this.listPreco.TabIndex = 2;
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.AutoSize = true;
            this.lblTotalVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVendas.Location = new System.Drawing.Point(668, 359);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(36, 37);
            this.lblTotalVendas.TabIndex = 3;
            this.lblTotalVendas.Text = "0";
            this.lblTotalVendas.Click += new System.EventHandler(this.lblTotalVendas_Click);
            // 
            // bntRemover
            // 
            this.bntRemover.Location = new System.Drawing.Point(181, 139);
            this.bntRemover.Name = "bntRemover";
            this.bntRemover.Size = new System.Drawing.Size(75, 23);
            this.bntRemover.TabIndex = 4;
            this.bntRemover.Text = "Remover";
            this.bntRemover.UseVisualStyleBackColor = true;
            this.bntRemover.Click += new System.EventHandler(this.bntRemover_Click);
            // 
            // bntLancar
            // 
            this.bntLancar.Location = new System.Drawing.Point(382, 51);
            this.bntLancar.Name = "bntLancar";
            this.bntLancar.Size = new System.Drawing.Size(75, 23);
            this.bntLancar.TabIndex = 5;
            this.bntLancar.Text = "Lançar";
            this.bntLancar.UseVisualStyleBackColor = true;
            this.bntLancar.Click += new System.EventHandler(this.bntLancar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Vendas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntLancar);
            this.Controls.Add(this.bntRemover);
            this.Controls.Add(this.lblTotalVendas);
            this.Controls.Add(this.listPreco);
            this.Controls.Add(this.listProduto);
            this.Controls.Add(this.textPreco);
            this.Controls.Add(this.textProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPreco;
        private System.Windows.Forms.ListBox listProduto;
        private System.Windows.Forms.ListBox listPreco;
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Button bntRemover;
        private System.Windows.Forms.Button bntLancar;
        private System.Windows.Forms.Label label3;
    }
}

