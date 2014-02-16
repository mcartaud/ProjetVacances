namespace LireCommandeMSMQ
{
    partial class Form1
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
            this.btnLire = new System.Windows.Forms.Button();
            this.txtListe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLire
            // 
            this.btnLire.Location = new System.Drawing.Point(12, 488);
            this.btnLire.Name = "btnLire";
            this.btnLire.Size = new System.Drawing.Size(802, 34);
            this.btnLire.TabIndex = 2;
            this.btnLire.Text = "Lire la file d\'attente (Vol et Hotel)";
            this.btnLire.UseVisualStyleBackColor = true;
            this.btnLire.Click += new System.EventHandler(this.btnLire_Click);
            // 
            // txtListe
            // 
            this.txtListe.Location = new System.Drawing.Point(16, 55);
            this.txtListe.Multiline = true;
            this.txtListe.Name = "txtListe";
            this.txtListe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListe.Size = new System.Drawing.Size(798, 409);
            this.txtListe.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 551);
            this.Controls.Add(this.txtListe);
            this.Controls.Add(this.btnLire);
            this.Name = "Form1";
            this.Text = "Lire MSMQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLire;
        private System.Windows.Forms.TextBox txtListe;
    }
}

