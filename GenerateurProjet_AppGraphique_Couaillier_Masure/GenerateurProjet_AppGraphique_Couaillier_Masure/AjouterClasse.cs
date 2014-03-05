using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateurProjet_AppGraphique_Couaillier_Masure
{
    public partial class Form_AjouterClasse : Form
    {
        public Form_AjouterClasse()
        {
            InitializeComponent();
        }

        private void btn_AjouterVariable_Click(object sender, EventArgs e)
        {
            Form_AjouterVariable AddVariable = new Form_AjouterVariable();
            AddVariable.ShowDialog();
        }

        private void btn_AjouterFonction_Click(object sender, EventArgs e)
        {
            Form_AjouterFonction AddFonction = new Form_AjouterFonction();
            AddFonction.ShowDialog();
        }
        
        private void btn_AjouterAutreClasse_Click(object sender, EventArgs e)
        {
            //!\\action de sauvegarde à faire //!\\
            Form_AjouterClasse NClass = new Form_AjouterClasse();
            NClass.Show();
            this.Close();
            
        }

        

    }
}
