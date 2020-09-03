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
            this.btnAffiche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAffiche
            // 
            this.btnAffiche.Location = new System.Drawing.Point(280, 82);
            this.btnAffiche.Name = "btnAffiche";
            this.btnAffiche.Size = new System.Drawing.Size(75, 23);
            this.btnAffiche.TabIndex = 0;
            this.btnAffiche.Text = "Affiche";
            this.btnAffiche.UseVisualStyleBackColor = true;
            this.btnAffiche.Click += new System.EventHandler(this.btnAffiche_Click);
            // 
            // frmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAffiche);
            this.Name = "frmConversion";
            this.Text = "Conversion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAffiche;
    }
}

