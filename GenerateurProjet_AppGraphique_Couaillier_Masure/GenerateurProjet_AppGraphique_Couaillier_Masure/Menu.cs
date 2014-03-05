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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void btn_AjouterClasse_Click(object sender, EventArgs e)
        {
            Form_AjouterClasse NClass = new Form_AjouterClasse();
            NClass.ShowDialog();
        }
    }
}
