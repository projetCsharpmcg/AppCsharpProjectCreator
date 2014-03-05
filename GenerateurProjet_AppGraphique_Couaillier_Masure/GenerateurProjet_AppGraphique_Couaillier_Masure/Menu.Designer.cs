namespace GenerateurProjet_AppGraphique_Couaillier_Masure
{
    partial class Form_Menu
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
            this.picb_Menu = new System.Windows.Forms.PictureBox();
            this.btn_AjouterClasse = new System.Windows.Forms.Button();
            this.btn_ModifierClasse = new System.Windows.Forms.Button();
            this.lbox_ListeClasse = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // picb_Menu
            // 
            this.picb_Menu.Location = new System.Drawing.Point(12, 12);
            this.picb_Menu.Name = "picb_Menu";
            this.picb_Menu.Size = new System.Drawing.Size(128, 329);
            this.picb_Menu.TabIndex = 0;
            this.picb_Menu.TabStop = false;
            // 
            // btn_AjouterClasse
            // 
            this.btn_AjouterClasse.Location = new System.Drawing.Point(146, 22);
            this.btn_AjouterClasse.Name = "btn_AjouterClasse";
            this.btn_AjouterClasse.Size = new System.Drawing.Size(324, 40);
            this.btn_AjouterClasse.TabIndex = 1;
            this.btn_AjouterClasse.Text = "Ajouter Classe";
            this.btn_AjouterClasse.UseVisualStyleBackColor = true;
            this.btn_AjouterClasse.Click += new System.EventHandler(this.btn_AjouterClasse_Click);
            // 
            // btn_ModifierClasse
            // 
            this.btn_ModifierClasse.Enabled = false;
            this.btn_ModifierClasse.Location = new System.Drawing.Point(146, 83);
            this.btn_ModifierClasse.Name = "btn_ModifierClasse";
            this.btn_ModifierClasse.Size = new System.Drawing.Size(324, 40);
            this.btn_ModifierClasse.TabIndex = 2;
            this.btn_ModifierClasse.Text = "Modifier Classe";
            this.btn_ModifierClasse.UseVisualStyleBackColor = true;
            // 
            // lbox_ListeClasse
            // 
            this.lbox_ListeClasse.FormattingEnabled = true;
            this.lbox_ListeClasse.ItemHeight = 16;
            this.lbox_ListeClasse.Location = new System.Drawing.Point(146, 144);
            this.lbox_ListeClasse.Name = "lbox_ListeClasse";
            this.lbox_ListeClasse.Size = new System.Drawing.Size(324, 196);
            this.lbox_ListeClasse.TabIndex = 3;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.lbox_ListeClasse);
            this.Controls.Add(this.btn_ModifierClasse);
            this.Controls.Add(this.btn_AjouterClasse);
            this.Controls.Add(this.picb_Menu);
            this.Name = "Form_Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picb_Menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picb_Menu;
        private System.Windows.Forms.Button btn_AjouterClasse;
        private System.Windows.Forms.Button btn_ModifierClasse;
        private System.Windows.Forms.ListBox lbox_ListeClasse;
    }
}