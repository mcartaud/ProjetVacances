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
            this.listBoxVols = new System.Windows.Forms.ListBox();
            this.listBoxHotels = new System.Windows.Forms.ListBox();
            this.btnLire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxVols
            // 
            this.listBoxVols.FormattingEnabled = true;
            this.listBoxVols.ItemHeight = 16;
            this.listBoxVols.Location = new System.Drawing.Point(12, 65);
            this.listBoxVols.Name = "listBoxVols";
            this.listBoxVols.Size = new System.Drawing.Size(393, 404);
            this.listBoxVols.TabIndex = 0;
            // 
            // listBoxHotels
            // 
            this.listBoxHotels.FormattingEnabled = true;
            this.listBoxHotels.ItemHeight = 16;
            this.listBoxHotels.Location = new System.Drawing.Point(411, 65);
            this.listBoxHotels.Name = "listBoxHotels";
            this.listBoxHotels.Size = new System.Drawing.Size(404, 404);
            this.listBoxHotels.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vols";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hotels";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLire);
            this.Controls.Add(this.listBoxHotels);
            this.Controls.Add(this.listBoxVols);
            this.Name = "Form1";
            this.Text = "Lire MSMQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVols;
        private System.Windows.Forms.ListBox listBoxHotels;
        private System.Windows.Forms.Button btnLire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

