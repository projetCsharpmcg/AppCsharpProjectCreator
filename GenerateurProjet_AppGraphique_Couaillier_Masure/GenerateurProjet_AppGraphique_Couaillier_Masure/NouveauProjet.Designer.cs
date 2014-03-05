namespace GenerateurProjet_AppGraphique_Couaillier_Masure
{
    partial class Form_NouveauProjet
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
            this.lbl_NomProjet = new System.Windows.Forms.Label();
            this.tbx_NomProjet = new System.Windows.Forms.TextBox();
            this.btn_Suivant = new System.Windows.Forms.Button();
            this.picb_Nouveauprojet = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_resgister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Nouveauprojet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NomProjet
            // 
            this.lbl_NomProjet.AutoSize = true;
            this.lbl_NomProjet.Location = new System.Drawing.Point(174, 28);
            this.lbl_NomProjet.Name = "lbl_NomProjet";
            this.lbl_NomProjet.Size = new System.Drawing.Size(179, 17);
            this.lbl_NomProjet.TabIndex = 0;
            this.lbl_NomProjet.Text = "Quel est le nom du projet ?";
            // 
            // tbx_NomProjet
            // 
            this.tbx_NomProjet.Location = new System.Drawing.Point(177, 58);
            this.tbx_NomProjet.Name = "tbx_NomProjet";
            this.tbx_NomProjet.Size = new System.Drawing.Size(176, 22);
            this.tbx_NomProjet.TabIndex = 1;
            // 
            // btn_Suivant
            // 
            this.btn_Suivant.Location = new System.Drawing.Point(381, 311);
            this.btn_Suivant.Name = "btn_Suivant";
            this.btn_Suivant.Size = new System.Drawing.Size(89, 30);
            this.btn_Suivant.TabIndex = 2;
            this.btn_Suivant.Text = "Suivant";
            this.btn_Suivant.UseVisualStyleBackColor = true;
            this.btn_Suivant.Click += new System.EventHandler(this.btn_Suivant_Click);
            // 
            // picb_Nouveauprojet
            // 
            this.picb_Nouveauprojet.Location = new System.Drawing.Point(12, 12);
            this.picb_Nouveauprojet.Name = "picb_Nouveauprojet";
            this.picb_Nouveauprojet.Size = new System.Drawing.Size(156, 329);
            this.picb_Nouveauprojet.TabIndex = 3;
            this.picb_Nouveauprojet.TabStop = false;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btn_resgister
            // 
            this.btn_resgister.Location = new System.Drawing.Point(177, 96);
            this.btn_resgister.Name = "btn_resgister";
            this.btn_resgister.Size = new System.Drawing.Size(141, 30);
            this.btn_resgister.TabIndex = 4;
            this.btn_resgister.Text = "Enregistrer sous";
            this.btn_resgister.UseVisualStyleBackColor = true;
            this.btn_resgister.Click += new System.EventHandler(this.btn_resgister_Click);
            // 
            // Form_NouveauProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.btn_resgister);
            this.Controls.Add(this.picb_Nouveauprojet);
            this.Controls.Add(this.btn_Suivant);
            this.Controls.Add(this.tbx_NomProjet);
            this.Controls.Add(this.lbl_NomProjet);
            this.Name = "Form_NouveauProjet";
            this.Text = "Nouveau Projet";
            ((System.ComponentModel.ISupportInitialize)(this.picb_Nouveauprojet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NomProjet;
        private System.Windows.Forms.TextBox tbx_NomProjet;
        private System.Windows.Forms.Button btn_Suivant;
        private System.Windows.Forms.PictureBox picb_Nouveauprojet;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        protected System.Windows.Forms.Button btn_resgister;
    }
}

