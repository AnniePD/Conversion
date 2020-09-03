namespace Conversion
{
    partial class frmConversion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBinaire = new System.Windows.Forms.TextBox();
            this.txtHexa = new System.Windows.Forms.TextBox();
            this.txtDecimale = new System.Windows.Forms.TextBox();
            this.txtEntree = new System.Windows.Forms.TextBox();
            this.btnHexa = new System.Windows.Forms.Button();
            this.btnDecimale = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBinaire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conversion";
            // 
            // txtBinaire
            // 
            this.txtBinaire.Location = new System.Drawing.Point(122, 120);
            this.txtBinaire.Name = "txtBinaire";
            this.txtBinaire.Size = new System.Drawing.Size(100, 20);
            this.txtBinaire.TabIndex = 2;
            // 
            // txtHexa
            // 
            this.txtHexa.Location = new System.Drawing.Point(338, 120);
            this.txtHexa.Name = "txtHexa";
            this.txtHexa.Size = new System.Drawing.Size(100, 20);
            this.txtHexa.TabIndex = 3;
            // 
            // txtDecimale
            // 
            this.txtDecimale.Location = new System.Drawing.Point(565, 120);
            this.txtDecimale.Name = "txtDecimale";
            this.txtDecimale.Size = new System.Drawing.Size(100, 20);
            this.txtDecimale.TabIndex = 4;
            // 
            // txtEntree
            // 
            this.txtEntree.Location = new System.Drawing.Point(338, 230);
            this.txtEntree.Name = "txtEntree";
            this.txtEntree.Size = new System.Drawing.Size(100, 20);
            this.txtEntree.TabIndex = 5;
            // 
            // btnHexa
            // 
            this.btnHexa.Location = new System.Drawing.Point(348, 335);
            this.btnHexa.Name = "btnHexa";
            this.btnHexa.Size = new System.Drawing.Size(75, 23);
            this.btnHexa.TabIndex = 6;
            this.btnHexa.Text = "Hexa";
            this.btnHexa.UseVisualStyleBackColor = true;
            // 
            // btnDecimale
            // 
            this.btnDecimale.Location = new System.Drawing.Point(590, 335);
            this.btnDecimale.Name = "btnDecimale";
            this.btnDecimale.Size = new System.Drawing.Size(75, 23);
            this.btnDecimale.TabIndex = 7;
            this.btnDecimale.Text = "Décimale";
            this.btnDecimale.UseVisualStyleBackColor = true;
            this.btnDecimale.Click += new System.EventHandler(this.btnDecimale_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Binaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hexa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Décimale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Entrée";
            // 
            // btnBinaire
            // 
            this.btnBinaire.Location = new System.Drawing.Point(122, 335);
            this.btnBinaire.Name = "btnBinaire";
            this.btnBinaire.Size = new System.Drawing.Size(75, 23);
            this.btnBinaire.TabIndex = 12;
            this.btnBinaire.Text = "Binaire";
            this.btnBinaire.UseVisualStyleBackColor = true;
            this.btnBinaire.Click += new System.EventHandler(this.btnBinaire_Click);
            // 
            // frmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBinaire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecimale);
            this.Controls.Add(this.btnHexa);
            this.Controls.Add(this.txtEntree);
            this.Controls.Add(this.txtDecimale);
            this.Controls.Add(this.txtHexa);
            this.Controls.Add(this.txtBinaire);
            this.Controls.Add(this.label1);
            this.Name = "frmConversion";
            this.Text = "Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBinaire;
        private System.Windows.Forms.TextBox txtHexa;
        private System.Windows.Forms.TextBox txtDecimale;
        private System.Windows.Forms.TextBox txtEntree;
        private System.Windows.Forms.Button btnHexa;
        private System.Windows.Forms.Button btnDecimale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBinaire;
    }
}

